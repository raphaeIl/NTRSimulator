using System.Buffers.Binary;
using System.Reflection;
using Google.Protobuf;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Common.Utils;
using PcapDotNet.Core;
using Serilog;

namespace NTRSimulator.PcapParser
{
    public class PcapParser
    {
        public List<TcpPacket> tcpPackets;
        public List<GfPacket> packets;
        public PcapParserMode parserMode;
        private int nextMainMessageId;

        public bool EnableVerboseLogging { get; set; } = true;
        public int FailedParsingCount { get; private set; }
        public List<GfPacket> Packets => packets;

        // This is annoying but it is different when trying to pcap on official vs ps, for ps, on wireshark select
        // "loopback traffic capture" instead of the normal wifi capture when trying to pcap, FOR PS ONLY.
        // The main difference is that the "header" is included in IpV4.Tcp.Payload for loopback traffic so we need
        // to skip that, but not for normal wifi pcap.
        public PcapParser(PcapParserMode parserMode)
        {
            this.parserMode = parserMode;

            tcpPackets = [];
            packets = [];
        }

        public void ParsePackets(string pcapFilePath)
        {
            tcpPackets.Clear();
            packets.Clear();
            nextMainMessageId = 0;
            FailedParsingCount = 0;

            OfflinePacketDevice selectedDevice = new(pcapFilePath);
            using PacketCommunicator communicator =
                selectedDevice.Open(
                    65536,
                    PacketDeviceOpenAttributes.Promiscuous,
                    1000
                );

            communicator.ReceivePackets(0, DispatcherHandler);

            ProcessTCPPackets();

            Log.Information("Parsed a total of {PacketCount} packets!", packets.Count);
        }

        private void DispatcherHandler(PcapDotNet.Packets.Packet packet)
        {
            var payload = parserMode == PcapParserMode.Offical || parserMode == PcapParserMode.Official
                ? packet.Ethernet.IpV4.Tcp.Payload
                : packet.IpV4.Tcp.Payload;
            string sourceIp = (parserMode == PcapParserMode.Offical || parserMode == PcapParserMode.Official
                ? packet.Ethernet.IpV4.Source
                : packet.IpV4.Source).ToString();
            string destinationIp = (parserMode == PcapParserMode.Offical || parserMode == PcapParserMode.Official
                ? packet.Ethernet.IpV4.Destination
                : packet.IpV4.Destination).ToString();
            PacketType packetType = DeterminePacketType(sourceIp, destinationIp);

            if (payload.Length < 1)
            {
                return;
            }

            Log.Information("=======================================================================");
            byte[] rawData = parserMode == PcapParserMode.Offical || parserMode == PcapParserMode.Official
                ? payload.ToArray()
                : payload.ToArray()[packet.IpV4.HeaderLength..];

            TcpPacket receivedPacket = new()
            {
                TimeStamp = packet.Timestamp,
                TCPPayloadLength = payload.Length,
                SequenceNumber = packet.Ethernet.IpV4.Tcp.SequenceNumber,
                RawData = rawData,
                PacketType = packetType,
            };

            tcpPackets.Add(receivedPacket);

            receivedPacket.PrintString();
            Log.Information("=======================================================================");
            Log.Information("");
        }

        private void ProcessTCPPackets()
        {
            Log.Information("Received {TcpPacketCount} TCP Packets, now processing...", tcpPackets.Count);
            ILookup<PacketType, TcpPacket> packetsByType = tcpPackets.ToLookup(packet => packet.PacketType);
            foreach (IGrouping<PacketType, TcpPacket> packetGroup in packetsByType)
            {
                List<TcpPacket> orderedPackets = packetGroup.OrderBy(packet => packet.SequenceNumber).ToList();
                int totalLength = orderedPackets.Sum(packet => packet.RawData.Length);

                Log.Information(
                    "Processing {PacketType} stream: {TcpPacketCount} tcp packets, combined size {CombinedSize} bytes",
                    packetGroup.Key,
                    orderedPackets.Count,
                    totalLength
                );

                byte[] combinedData = new byte[totalLength];
                int currentIndex = 0;
                foreach (TcpPacket packet in orderedPackets)
                {
                    Array.Copy(packet.RawData, 0, combinedData, currentIndex, packet.RawData.Length);

                    currentIndex += packet.RawData.Length;
                }

                SimulateSessionLoop(combinedData, packetGroup.Key);
            }
        }

        public void SimulateSessionLoop(byte[] combinedData, PacketType packetType)
        {
            using MemoryStream stream = new(combinedData);

            while (stream.Position + MainMessage.HeaderLength <= combinedData.Length)
            {
                byte[] headerBytes = new byte[MainMessage.HeaderLength];
                int headerRead = stream.Read(headerBytes, 0, MainMessage.HeaderLength);
                if (headerRead < MainMessage.HeaderLength)
                {
                    break;
                }

                Log.Information(
                    "Detected packet with header: {HeaderBytes}",
                    BitConverter.ToString(headerBytes).Replace("-", " ")
                );

                ushort mainMessageLength;
                try
                {
                    mainMessageLength = MainMessage.CalculateMainMessageLength(headerBytes);
                }
                catch (Exception ex)
                {
                    FailedParsingCount++;
                    Log.Information(
                        "[{PacketType}] Failed to decode main header: {ErrorMessage}",
                        packetType,
                        ex.GetBaseException().Message
                    );
                    break;
                }
                Log.Information("Calculated Expected Length: {MainMessageLength}", mainMessageLength);

                if (stream.Position + mainMessageLength > combinedData.Length)
                {
                    FailedParsingCount++;
                    Log.Information(
                        "[{PacketType}] Truncated frame declared length {MainMessageLength}; stopping this stream.",
                        packetType,
                        mainMessageLength
                    );
                    break;
                }

                byte[] msg = new byte[mainMessageLength];
                int bodyRead = stream.Read(msg, 0, mainMessageLength);
                if (bodyRead < mainMessageLength)
                {
                    FailedParsingCount++;
                    Log.Information(
                        "Truncated main message body at stream position {StreamPosition}. Stopping parse.",
                        stream.Position
                    );
                    break;
                }

                try
                {
                    MainMessage mainMessage = new(headerBytes.Concat(msg).ToArray());
                    Log.Information(
                        "Main Message seqId: {SequenceId}, length: {Length} isEncrypted: {IsEncrypted}, encryptedByte: {EncryptedByte}",
                        mainMessage.SequenceId,
                        mainMessage.Length,
                        mainMessage.IsEncrypted,
                        mainMessage.EncryptionByte
                    );

                    int totalPacketLengths = 4;
                    int mainMessageId = nextMainMessageId++;
                    int packetIndex = 0;

                    foreach (BasePacket packet in mainMessage.Packets)
                    {
                        Log.Information("================================Packet==================================");
                        ProcessPacket(
                            packet,
                            mainMessage.SequenceId,
                            packetType,
                            mainMessageId,
                            packetIndex,
                            mainMessage.Length,
                            mainMessage.IsEncrypted,
                            mainMessage.EncryptionByte
                        );
                        packetIndex++;
                        totalPacketLengths += packet.RawPacketLength;
                        Log.Information("========================================================================");
                    }

                    Log.Information(
                        "Confirming total packets length: {TotalPacketLengths}: {LengthMatches}",
                        totalPacketLengths,
                        mainMessageLength == totalPacketLengths && mainMessage.Length == totalPacketLengths
                    );
                    Log.Information("");
                }
                catch (Exception ex)
                {
                    FailedParsingCount++;
                    Log.Information(
                        "[{PacketType}] Failed to decode main message: {ErrorMessage}",
                        packetType,
                        ex.GetBaseException().Message
                    );
                    break;
                }
            }
        }

        public void ProcessPacket(
            BasePacket packet,
            int sequenceId,
            PacketType packetType,
            int mainMessageId,
            int mainMessagePacketIndex,
            int mainMessageLength,
            bool mainMessageIsEncrypted,
            byte mainMessageEncryptedByte)
        {
            string packetName = packet.MsgId.ToString();
            MsgId msgId = packet.MsgId;

            if (!string.IsNullOrWhiteSpace(packetName))
            {
                //Log.Information("PacketType: {PacketType}", packetType);
                //Log.Information("Protocol: {PacketName}", packetName);
                //Log.Information("Packet id: {PacketId}, length: {PacketLength}", packet.Id, packet.Length);


                IMessage? parsedPacket = null;
                try
                {
                    parsedPacket = packet.Message;

                    if (parsedPacket is null)
                    {
                        bool isResolved = MsgIdResolver.TryResolve(
                            packet.RawMsgId,
                            out MsgId resolvedMsgId,
                            out string resolvedProtoName,
                            out string? resolvedTranslatedClassName
                        );

                        Log.Warning(
                            "IMessage parse returned null. RawMsgId={RawMsgId}, Length={PacketLength}, " +
                            "Resolved={Resolved}, ResolvedMsgId={ResolvedMsgId}, ProtoName={ProtoName}, " +
                            "TranslatedClass={TranslatedClass}, ParseError={ParseError}, " +
                            "UnknownFieldParseSucceeded={UnknownFieldParseSucceeded}, UnknownFieldParseError={UnknownFieldParseError}",
                            packet.RawMsgId,
                            packet.RawPacketLength,
                            isResolved,
                            resolvedMsgId,
                            resolvedProtoName,
                            resolvedTranslatedClassName ?? "<missing>"
                        );

                        Log.Warning(
                            "Null IMessage raw packet bytes: {PacketRawContents}",
                            BitConverter.ToString(packet.RawPacketData).Replace("-", " ")
                        );
                    }

                }
                catch
                {
                    FailedParsingCount++;
                    Log.Information("Unable to Parse IMessage for: {PacketName}", packetName);
                }

                GfPacket gfPacket = new()
                {
                    PacketLength = packet.RawPacketLength,
                    PacketName = packetName,
                    MsgId = msgId,
                    PacketMsgId = (ushort)msgId,
                    SeqId = sequenceId,
                    MainMessageId = mainMessageId,
                    MainMessagePacketIndex = mainMessagePacketIndex,
                    MainMessageLength = mainMessageLength,
                    MainMessageIsEncrypted = mainMessageIsEncrypted,
                    MainMessageEncryptedByte = mainMessageEncryptedByte,
                    PacketType = packetType,
                    Packet = parsedPacket,
                    RawPacket = packet.RawPacketData
                };
                gfPacket.PrintString();
                packets.Add(gfPacket);

                string packetJson = JsonConvert.SerializeObject(parsedPacket);
                //string packetJson = JsonConvert.SerializeObject(parsedPacket, Formatting.Indented);

                Log.Information("Packet Raw Contents: {PacketRawContents}", BitConverter.ToString(packet.RawPacketData).Replace("-", " "));
                Log.Information("packetJson: {PacketJson}", packetJson);
            }
            else
            {
                FailedParsingCount++;
                Log.Information("Unrecongnized MSG_ID {PacketId} received!", packet.MsgId);
            }
        }

        public void SavePackets(string filePath)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(packets, Formatting.Indented));
            Log.Information("Saved {PacketCount} packet(s)", packets.Count);
        }

        public static byte[] Combine(params byte[][] arrays)
        {
            if (arrays is null || arrays.Length == 0)
            {
                return Array.Empty<byte>();
            }

            int totalLength = arrays.Sum(array => array?.Length ?? 0);

            byte[] result = new byte[totalLength];
            int offset = 0;

            foreach (byte[]? array in arrays)
            {
                if (array is not null)
                {
                    Buffer.BlockCopy(array, 0, result, offset, array.Length);
                    offset += array.Length;
                }
            }

            return result;
        }

        private static PacketType DeterminePacketType(string sourceIp, string destinationIp)
        {
            bool sourceIsClient = sourceIp.StartsWith("192.168.", StringComparison.Ordinal);
            bool destinationIsClient = destinationIp.StartsWith("192.168.", StringComparison.Ordinal);

            if (sourceIsClient && !destinationIsClient)
            {
                return PacketType.REQUEST;
            }

            if (!sourceIsClient && destinationIsClient)
            {
                return PacketType.RESPONSE;
            }

            return sourceIsClient ? PacketType.REQUEST : PacketType.RESPONSE;
        }
    }

    public class TcpPacket
    {
        public DateTime TimeStamp { get; set; }

        public uint SequenceNumber { get; set; }

        public int TCPPayloadLength { get; set; }

        public byte[] RawData { get; set; } = [];

        [JsonConverter(typeof(StringEnumConverter))]
        public PacketType PacketType { get; set; }

        public ushort Estimated_SeqId =>
            RawData.Length >= 2 ? BinaryPrimitives.ReadUInt16LittleEndian(RawData.AsSpan()[..2]) : (ushort)0;

        public bool Estimated_IsEncrypted => RawData.Length >= 5 && RawData.AsSpan()[4] > 0;

        public byte Estimated_EncryptedByte => RawData.Length >= 5 ? RawData[4] : (byte)0;

        public int Estimated_GFPacket_Length =>
            RawData.Length >= 5
                ? (
                    Estimated_IsEncrypted
                        ? BinaryPrimitives.ReadUInt16BigEndian(Crypto.XorCrypt(RawData[2..4], [RawData[4], 0x00]))
                        : BinaryPrimitives.ReadUInt16BigEndian(RawData.AsSpan()[2..4])
                )
                : 0;

        public void PrintString()
        {
            int headerLength = Math.Min(9, RawData.Length);
            Log.Information("TCPPacket Details:");
            Log.Information("Timestamp            : {Timestamp:yyyy-MM-dd HH:mm:ss.fff}", TimeStamp);
            Log.Information("TCP Sequence Number  : {SequenceNumber}", SequenceNumber);
            Log.Information("Packet Type          : {PacketType}", PacketType);
            Log.Information("TCP Payload Length   : {TcpPayloadLength}", TCPPayloadLength);
            Log.Information("Raw Data Header      : {RawDataHeader}", BitConverter.ToString(RawData[..headerLength]).Replace("-", " "));
            Log.Information("");
            Log.Information("[Estimated] SeqId          : {EstimatedSeqId}", Estimated_SeqId);
            Log.Information("[Estimated] IsEncrypted    : {EstimatedIsEncrypted}", Estimated_IsEncrypted);
            Log.Information("[Estimated] EncryptedByte  : {EstimatedEncryptedByte}", Estimated_EncryptedByte);
            Log.Information("[Estimated] GFPacket Length: {EstimatedPacketLength}", Estimated_GFPacket_Length);
        }
    }

    public class GfPacket
    {
        public int PacketLength { get; set; }

        public string PacketName { get; set; } = string.Empty;

        [JsonConverter(typeof(StringEnumConverter))]
        public MsgId MsgId { get; set; }

        public ushort PacketMsgId { get; set; }

        public int SeqId { get; set; }

        public int MainMessageId { get; set; }

        public int MainMessagePacketIndex { get; set; }

        public int MainMessageLength { get; set; }

        public bool MainMessageIsEncrypted { get; set; }

        public byte MainMessageEncryptedByte { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PacketType PacketType { get; set; }

        public IMessage? Packet { get; set; }

        [JsonIgnore]
        public byte[] RawPacket { get; set; } = [];

        public BasePacket ToBasePacket()
        {
            if (RawPacket.Length > 0)
            {
                return new BasePacket(RawPacket);
            }

            ushort rawMsgId = MsgId != MsgId.MsgNone ? (ushort)MsgId : PacketMsgId;
            return new BasePacket(rawMsgId, Packet?.ToByteArray() ?? []);
        }

        public void PrintString()
        {
            Log.Information("GFPacket Details:");
            Log.Information("PacketName   : {PacketName}", PacketName);
            Log.Information("MsgId        : {MsgId}", MsgId);
            Log.Information("PacketMsgId  : {PacketMsgId}", PacketMsgId);
            Log.Information("SeqId        : {SeqId}", SeqId);
            Log.Information("MainMsgId    : {MainMessageId}", MainMessageId);
            Log.Information("MainMsgIndex : {MainMessagePacketIndex}", MainMessagePacketIndex);
            Log.Information("MainMsgLength: {MainMessageLength}", MainMessageLength);
            Log.Information("IsEncrypted  : {MainMessageIsEncrypted}", MainMessageIsEncrypted);
            Log.Information("EncryptedByte: {MainMessageEncryptedByte}", MainMessageEncryptedByte);
            Log.Information("PacketType   : {PacketType}", PacketType);
            Log.Information("PacketLength : {PacketLength}", PacketLength);
        }
    }

    public enum PcapParserMode
    {
        Offical = 0,
        PS = 1,
        Official = Offical,
        PrivateServerLoopback = PS,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PacketType
    {
        REQUEST = 0,
        RESPONSE = 1,
    }
}
