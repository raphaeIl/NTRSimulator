using System.Buffers.Binary;
using NTRSimulator.Common.Utils;

namespace NTRSimulator.Common.Protocol
{
    public sealed record MainMessage
    {
        public const ushort HeaderLength = MainMessageHeader.HeaderLength;
        public ushort SequenceId => Header.SequenceId;
        public ushort Length => Header.MessageLength;
        public bool IsEncrypted => Header.IsEncrypted;
        public byte EncryptionByte => Header.EncryptionByte;

        public MainMessageHeader Header { get; private set; }

        public IReadOnlyList<BasePacket> Packets { get; }

        public MainMessage(ReadOnlySpan<byte> data)
        {
            if (data.Length < MainMessageHeader.HeaderLength)
            {
                throw new ArgumentException("Packet data must include a 5-byte header.", nameof(data));
            }

            this.Header = MainMessageHeader.DecodeFromBytes(data[..MainMessageHeader.HeaderLength]);

            int totalMainMessageLen = MainMessageHeader.HeaderLength + Header.MessageLength;

            if (data.Length < totalMainMessageLen)
            {
                throw new ArgumentException("Main message data is shorter than its declared length.", nameof(data));
            }

            List<BasePacket> packets = [];
            int readOffset = MainMessageHeader.HeaderLength;
            int endOffset = totalMainMessageLen;
            while (readOffset < endOffset)
            {
                BasePacket packet = new(data[readOffset..endOffset]);
                packets.Add(packet);
                readOffset += BasePacketHeader.HeaderLength + packet.Header.IMessageLength;
            }

            if (readOffset != endOffset)
            {
                throw new ArgumentException("Main message body contains trailing or malformed packet bytes.", nameof(data));
            }

            Packets = packets;
        }

        public MainMessage(ushort sequenceId, byte encryptionByte, params BasePacket[] packets)
        {
            ushort length = checked((ushort)packets.Sum(packet => BasePacketHeader.HeaderLength + packet.Header.IMessageLength));
            this.Header = new MainMessageHeader(sequenceId, length, encryptionByte);
            
            Packets = packets;
        }

        public byte[] ToRawMessageData()
        {
            byte[] rawBytes = GC.AllocateUninitializedArray<byte>(HeaderLength + Length);
            WriteHeader(rawBytes);
            int writeOffset = HeaderLength;
            foreach (BasePacket packet in Packets)
            {
                byte[] packetBytes = packet.RawPacketData;
                packetBytes.CopyTo(rawBytes.AsSpan(writeOffset));
                writeOffset += packetBytes.Length;
            }
            return rawBytes;
        }

        public static ushort CalculateMainMessageLength(ReadOnlySpan<byte> headerBytes)
        {
            return MainMessageHeader.DecodeFromBytes(headerBytes).MessageLength;
        }

        private void WriteHeader(Span<byte> target)
        {
            BinaryPrimitives.WriteUInt16LittleEndian(target.Slice(MainMessageHeader.SequenceOffset, 2), Header.SequenceId);
            BinaryPrimitives.WriteUInt16BigEndian(target.Slice(MainMessageHeader.LengthOffset, 2), Header.MessageLength);

            if (Header.IsEncrypted)
            {
                byte[] encodedLength = Crypto.XorCrypt(target.Slice(MainMessageHeader.LengthOffset, 2).ToArray(), [Header.EncryptionByte, 0]);
                encodedLength.CopyTo(target.Slice(MainMessageHeader.LengthOffset, 2));
            }

            target[MainMessageHeader.EncryptionOffset] = Header.EncryptionByte;
        }
    }

    public readonly record struct MainMessageHeader(ushort SequenceId, ushort MessageLength, byte EncryptionByte)
    {
        //     seqId              len         encrypt byte
        public const int HeaderLength = sizeof(ushort) + sizeof(ushort) + sizeof(bool);
        public const int SequenceOffset = 0;
        public const int LengthOffset = sizeof(ushort);
        public const int EncryptionOffset = sizeof(ushort) + sizeof(ushort);

        public bool IsEncrypted => EncryptionByte > 0;

        /// <summary>
        /// Client XOR-masks the 2-byte body length when this is non-zero.
        /// Observed rule: encryptionByte = floor(bodyLength / 255).
        /// </summary>
        public static byte ComputeEncryptionByte(ushort bodyLength) => (byte)(bodyLength / 255);

        public static MainMessageHeader DecodeFromBytes(ReadOnlySpan<byte> headerBytes)
        {
            if (headerBytes.Length < HeaderLength)
            {
                throw new ArgumentException("Header must be at least 5 bytes long.", nameof(headerBytes));
            }

            byte encryptionFlag = headerBytes[EncryptionOffset];
            ushort sequenceId = BinaryPrimitives.ReadUInt16LittleEndian(headerBytes.Slice(SequenceOffset, 2));
            ushort length = DecodeBodyLength(headerBytes, encryptionFlag);
            return new MainMessageHeader(sequenceId, length, encryptionFlag);
        }

        public static ushort DecodeBodyLength(ReadOnlySpan<byte> headerBytes, byte encryptionFlag)
        {
            byte[] lengthBytes = headerBytes.Slice(2, 2).ToArray();
            if (encryptionFlag > 0)
            {
                lengthBytes = Crypto.XorCrypt(lengthBytes, [encryptionFlag, 0]);
            }

            return BinaryPrimitives.ReadUInt16BigEndian(lengthBytes);
        }
    }
}
