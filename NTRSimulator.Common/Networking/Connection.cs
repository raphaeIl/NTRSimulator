using Google.Protobuf;
using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Manager;
using NTRSimulator.Common.Packets;
using NTRSimulator.Common.Protocol;
using NTRSimulator.Common.Utils;
using NTRSimulator.Database.Entities;
using System.Net.Sockets;

namespace NTRSimulator.Common.Networking
{
    public class Connection(
        TcpClient client,
        PacketDispatcher dispatcher,
        ConnectionManager connectionManager,
        ILogger logger)
    {
        public PlayerSession? Session { get; set; }
        public AccountEntity? Account { get; set; }
        public long? ServerTimeOverride { get; set; }

        private readonly NetworkStream _stream = client.GetStream();

        private ushort sendSequence = 0;
        private static readonly HashSet<MsgId> DeferredMsgIds =
        [
            MsgId.MsgCsSync,
            MsgId.MsgScSync,
            MsgId.MsgScRecordStatisticUpdate
        ];

        public string Id { get; } = client.Client.RemoteEndPoint!.ToString()!;

        public void Run()
        {
            connectionManager.Add(this);
            logger.LogInformation("{Id} connected", Id);

            try
            {
                while (client.Connected)
                {
                    MainMessage? mainMessage = PacketFramer.Read(_stream);
                    if (mainMessage is null)
                    {
                        break;
                    }

                    PacketUtils.LogBasePackets(
                        "Received",
                        "Receiving",
                        mainMessage.Packets,
                        mainMessage.SequenceId,
                        mainMessage.Header.EncryptionByte,
                        mainMessage.ToRawMessageData(),
                        logger);

                    if (mainMessage.Packets.Count > 0
                        && (mainMessage.Packets.Count > 1
                            || !DeferredMsgIds.Contains(mainMessage.Packets[0].MsgId)))
                    {
                        sendSequence = mainMessage.SequenceId;
                    }

                    dispatcher.Dispatch(this, mainMessage);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error handling TCP client");
            }
            finally
            {
                connectionManager.Remove(this);
                client.Close();
                logger.LogInformation("{Id} disconnected", Id);
            }
        }

        public void Send(params object[] messages)
        {
            IMessage[] imessages = new IMessage[messages.Length];
            for (int i = 0; i < messages.Length; i++)
            {
                if (messages[i] is not IMessage message)
                {
                    throw new ArgumentException(
                        $"Send argument at index {i} is not a protobuf IMessage (runtime type: {messages[i]?.GetType().FullName ?? "null"}).",
                        nameof(messages)
                    );
                }

                imessages[i] = message;
            }

            this.SendPacketList(sendSequence, 0, imessages);
        }

        public void Send<T>(params T[] messages) where T : IMessage
        {
            this.SendPacketList(sendSequence, 0, messages.Cast<IMessage>().ToArray());
        }

        public void Send<T>(byte encryptionByte, params T[] messages)
            where T : IMessage
        {
            this.SendPacketList(sendSequence, encryptionByte, messages.Cast<IMessage>().ToArray());
        }

        public void SendEncrypted(byte encryptionByte, params IMessage[] messages)
        {
            this.SendPacketList(sendSequence, encryptionByte, messages);
        }

        /// <summary>
        /// Sends with encryptionByte = bodyLength / 255 (XOR length masking when non-zero).
        /// </summary>
        public void SendAutoEncrypted<T>(params T[] messages) where T : IMessage
        {
            ArgumentNullException.ThrowIfNull(messages);

            BasePacket[] basePackets = BuildBasePackets(messages.Cast<IMessage>());
            if (basePackets.Length == 0)
            {
                return;
            }

            ushort bodyLength = checked((ushort)basePackets.Sum(
                packet => BasePacketHeader.HeaderLength + packet.Header.IMessageLength));
            byte encryptionByte = MainMessageHeader.ComputeEncryptionByte(bodyLength);

            ushort resolvedSequenceId = basePackets.Length == 1 && DeferredMsgIds.Contains(basePackets[0].MsgId)
                ? (ushort)0
                : sendSequence;

            Send(new MainMessage(resolvedSequenceId, encryptionByte, basePackets));
        }

        public void SendPacketList(ushort sequenceId, byte encryptionByte, params IMessage[] messages)
        {
            ArgumentNullException.ThrowIfNull(messages);

            //BasePacket[] basePackets = BuildBasePackets(messages);
            //if (basePackets.Length == 0)
            //{
            //    return;
            //}

            //ushort resolvedSequenceId = basePackets.Length == 1 && DeferredMsgIds.Contains(basePackets[0].MsgId)
            //    ? (ushort)0
            //    : sequenceId;

            //Send(new MainMessage(resolvedSequenceId, encryptionByte, basePackets));
            this.SendAutoEncrypted(messages);
        }

        private void Send(params MainMessage[] messages)
        {
            if (_stream is null)
            {
                throw new InvalidOperationException("Cannot send before the client loop starts.");
            }

            foreach (MainMessage message in messages)
            {
                PacketUtils.LogBasePackets("Sending", "Sending", message.Packets, message.SequenceId, message.Header.EncryptionByte, message.ToRawMessageData(), logger);

                PacketFramer.WriteClientSizedChunks(_stream, message.ToRawMessageData());
            }
        }

        public void SendUnsequenced<T>(params T[] messages)
            where T : IMessage
        {
            SendUnsequenced(messages.Cast<IMessage>().ToArray());
        }

        public void SendUnsequenced<T>(byte encryptionFlag, params T[] messages)
            where T : IMessage
        {
            SendUnsequenced(encryptionFlag, messages.Cast<IMessage>().ToArray());
        }

        public void SendUnsequenced(params IMessage[] messages)
        {
            SendWithSequence(0, 0, messages);
        }

        public void SendUnsequenced(byte encryptionFlag, params IMessage[] messages)
        {
            SendWithSequence(0, encryptionFlag, messages);
        }

        private void SendWithSequence(ushort sequenceId, byte encryptionByte, params IMessage[] messages)
        {
            ArgumentNullException.ThrowIfNull(messages);

            if (messages.Length == 0)
            {
                return;
            }

            this.SendPacketList(sequenceId, encryptionByte, messages);
        }

        public void SendRawMainMessageHexStream(string hexStream)
        {
            SendRawMainMessageHexStream(HexUtils.ParseHexStream(hexStream));
        }

        public void SendRawMainMessageHexStream(byte[] rawMainMessage)
        {
            SendRawMainMessageHexStream(rawMainMessage, logSummary: true);
        }

        public void SendRawMainMessageHexStream(byte[] rawMainMessage, bool logSummary)
        {
            if (_stream is null)
            {
                throw new InvalidOperationException("Cannot send before the client loop starts.");
            }

            if (rawMainMessage.Length < MainMessageHeader.HeaderLength)
            {
                throw new ArgumentException("Raw main message must include the 5-byte main message header.", nameof(rawMainMessage));
            }

            PacketFramer.WriteClientSizedChunks(_stream, rawMainMessage);
        }

        public void Close()
        {
            client.Close();
        }

        private BasePacket[] BuildBasePackets(IEnumerable<IMessage> messages)
        {
            return messages
                .Select((message, index) =>
                {
                    if (message is null)
                    {
                        throw new ArgumentException(
                            $"Cannot send null protobuf message at index {index}.",
                            nameof(messages)
                        );
                    }

                    if (!MsgIdResolver.TryGetRawMsgId(message, out ushort rawMsgId))
                    {
                        throw new InvalidOperationException(
                            $"Unable to resolve MsgId for protobuf type '{message.Descriptor.Name}' at index {index}."
                        );
                    }

                    return BasePacket.FromIMessageBytes(rawMsgId, ProtobufGameWireSerializer.ToByteArray(message));
                })
                .ToArray();
        }
    }
}
