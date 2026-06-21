using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace NTRSimulator.Common.Utils
{
    /// <summary>
    /// The official GF2 server writes explicit false values in bool map entries (field tag 0x10, value 0x00).
    /// Google.Protobuf omits those defaults, which changes packet sizes and can break the client.
    /// </summary>
    public static class ProtobufGameWireSerializer
    {
        private enum WireType : uint
        {
            Varint = 0,
            Fixed64 = 1,
            LengthDelimited = 2,
            StartGroup = 3,
            EndGroup = 4,
            Fixed32 = 5,
        }

        public static byte[] ToByteArray(IMessage message)
        {
            ArgumentNullException.ThrowIfNull(message);
            byte[] raw = message.ToByteArray();

            if (!HasBoolMapField(message.Descriptor))
            {
                return raw;
            }

            try
            {
                return PatchGameWireFormat(raw, message.Descriptor);
            }
            catch (InvalidOperationException)
            {
                return raw;
            }
        }

        public static byte[] PatchGameWireFormat(byte[] data, MessageDescriptor descriptor)
        {
            ArgumentNullException.ThrowIfNull(data);
            ArgumentNullException.ThrowIfNull(descriptor);
            return PatchMessage(data, descriptor);
        }

        private static bool HasBoolMapField(MessageDescriptor descriptor)
        {
            return HasBoolMapField(descriptor, new Dictionary<MessageDescriptor, bool?>());
        }

        private static bool HasBoolMapField(MessageDescriptor descriptor, Dictionary<MessageDescriptor, bool?> memo)
        {
            if (memo.TryGetValue(descriptor, out bool? cached))
            {
                // null means we're still walking this type (cycle); treat as no bool map on this branch.
                return cached ?? false;
            }

            memo[descriptor] = null;

            foreach (FieldDescriptor field in descriptor.Fields.InFieldNumberOrder())
            {
                if (IsBoolMapField(field))
                {
                    memo[descriptor] = true;
                    return true;
                }

                if (field.IsMap)
                {
                    FieldDescriptor? mapValueField = field.MessageType.FindFieldByNumber(2);
                    if (mapValueField?.FieldType == FieldType.Message && HasBoolMapField(mapValueField.MessageType, memo))
                    {
                        memo[descriptor] = true;
                        return true;
                    }

                    continue;
                }

                if (field.FieldType == FieldType.Message && HasBoolMapField(field.MessageType, memo))
                {
                    memo[descriptor] = true;
                    return true;
                }
            }

            memo[descriptor] = false;
            return false;
        }

        private static bool HasMessageMapValueWithBoolMaps(FieldDescriptor field)
        {
            if (!field.IsMap)
            {
                return false;
            }

            FieldDescriptor? valueField = field.MessageType.FindFieldByNumber(2);
            return valueField?.FieldType == FieldType.Message && HasBoolMapField(valueField.MessageType);
        }

        private static bool IsBoolMapField(FieldDescriptor field)
        {
            if (!field.IsMap)
            {
                return false;
            }

            FieldDescriptor? keyField = field.MessageType.FindFieldByNumber(1);
            FieldDescriptor? valueField = field.MessageType.FindFieldByNumber(2);
            if (keyField is null || valueField is null)
            {
                return false;
            }

            if (valueField.FieldType != FieldType.Bool)
            {
                return false;
            }

            return keyField.FieldType is FieldType.UInt32
                or FieldType.UInt64
                or FieldType.Int32
                or FieldType.Int64
                or FieldType.SInt32
                or FieldType.SInt64
                or FieldType.Fixed32
                or FieldType.Fixed64
                or FieldType.SFixed32
                or FieldType.SFixed64;
        }

        private static byte[] PatchMessage(ReadOnlySpan<byte> input, MessageDescriptor descriptor)
        {
            BufferWriter output = new(input.Length + 256);
            int pos = 0;

            while (pos < input.Length)
            {
                pos = CopyField(input, pos, output, descriptor);
            }

            return output.ToArray();
        }

        private static byte[] PatchBoolMapEntry(ReadOnlySpan<byte> payload, int valueFieldNumber)
        {
            if (MapEntryHasFieldNumber(payload, valueFieldNumber))
            {
                return payload.ToArray();
            }

            int valueFieldTag = (valueFieldNumber << 3) | (int)WireType.Varint;
            byte[] valueFieldTagBytes = EncodeVarint((ulong)valueFieldTag);

            byte[] patched = new byte[payload.Length + valueFieldTagBytes.Length + 1];
            payload.CopyTo(patched);
            valueFieldTagBytes.CopyTo(patched.AsSpan(payload.Length));
            patched[payload.Length + valueFieldTagBytes.Length] = 0x00;
            return patched;
        }

        private static bool MapEntryHasFieldNumber(ReadOnlySpan<byte> payload, int fieldNumber)
        {
            int pos = 0;

            while (pos < payload.Length)
            {
                ulong tag = ReadVarint(payload, ref pos);
                if ((int)(tag >> 3) == fieldNumber)
                {
                    return true;
                }

                SkipFieldValue(payload, ref pos, (WireType)(tag & 0x7));
            }

            return false;
        }

        private static int CopyField(ReadOnlySpan<byte> input, int pos, BufferWriter output, MessageDescriptor descriptor)
        {
            ulong tag = ReadVarint(input, ref pos);
            output.WriteVarint(tag);

            WireType wireType = (WireType)(tag & 0x7);
            int fieldNumber = (int)(tag >> 3);
            FieldDescriptor? field = descriptor.FindFieldByNumber(fieldNumber);

            switch (wireType)
            {
                case WireType.Varint:
                {
                    ulong value = ReadVarint(input, ref pos);
                    output.WriteVarint(value);
                    break;
                }

                case WireType.Fixed64:
                {
                    output.WriteRawBytes(input.Slice(pos, 8));
                    pos += 8;
                    break;
                }

                case WireType.LengthDelimited:
                {
                    ulong length = ReadVarint(input, ref pos);
                    ReadOnlySpan<byte> payload = input.Slice(pos, (int)length);
                    pos += (int)length;

                    byte[] patchedPayload = field switch
                    {
                        not null when IsBoolMapField(field) =>
                            PatchBoolMapEntry(payload, field.MessageType.FindFieldByNumber(2)!.FieldNumber),
                        not null when HasMessageMapValueWithBoolMaps(field) =>
                            PatchMessage(payload, field.MessageType),
                        { FieldType: FieldType.Message, IsMap: false } when HasBoolMapField(field.MessageType) =>
                            PatchMessage(payload, field.MessageType),
                        _ => payload.ToArray(),
                    };

                    output.WriteVarint((ulong)patchedPayload.Length);
                    output.WriteRawBytes(patchedPayload);
                    break;
                }

                case WireType.StartGroup:
                case WireType.EndGroup:
                    throw new InvalidOperationException($"Unsupported wire type: {wireType}");

                case WireType.Fixed32:
                {
                    output.WriteRawBytes(input.Slice(pos, 4));
                    pos += 4;
                    break;
                }

                default:
                    throw new InvalidOperationException($"Unknown wire type: {wireType}");
            }

            return pos;
        }

        private static void SkipFieldValue(ReadOnlySpan<byte> input, ref int pos, WireType wireType)
        {
            switch (wireType)
            {
                case WireType.Varint:
                    ReadVarint(input, ref pos);
                    break;

                case WireType.Fixed64:
                    pos += 8;
                    break;

                case WireType.LengthDelimited:
                {
                    ulong length = ReadVarint(input, ref pos);
                    pos += (int)length;
                    break;
                }

                case WireType.Fixed32:
                    pos += 4;
                    break;

                case WireType.StartGroup:
                case WireType.EndGroup:
                    throw new InvalidOperationException($"Unsupported wire type: {wireType}");

                default:
                    throw new InvalidOperationException($"Unknown wire type: {wireType}");
            }
        }

        private static byte[] EncodeVarint(ulong value)
        {
            Span<byte> buffer = stackalloc byte[10];
            int length = 0;

            do
            {
                buffer[length++] = (byte)(value | 0x80);
                value >>= 7;
            }
            while (value >= 0x80);

            buffer[length - 1] &= 0x7F;
            return buffer[..length].ToArray();
        }

        private static ulong ReadVarint(ReadOnlySpan<byte> input, ref int pos)
        {
            ulong result = 0;
            int shift = 0;

            while (pos < input.Length)
            {
                byte b = input[pos++];
                result |= (ulong)(b & 0x7F) << shift;

                if ((b & 0x80) == 0)
                {
                    return result;
                }

                shift += 7;

                if (shift >= 64)
                {
                    throw new InvalidOperationException("Varint is too long.");
                }
            }

            throw new InvalidOperationException("Unexpected end of input while reading varint.");
        }

        private sealed class BufferWriter
        {
            private byte[] buffer;
            private int length;

            public BufferWriter(int initialCapacity)
            {
                buffer = new byte[initialCapacity];
            }

            public void WriteVarint(ulong value)
            {
                while (value >= 0x80)
                {
                    WriteByte((byte)(value | 0x80));
                    value >>= 7;
                }

                WriteByte((byte)value);
            }

            public void WriteRawBytes(ReadOnlySpan<byte> bytes)
            {
                EnsureCapacity(length + bytes.Length);
                bytes.CopyTo(buffer.AsSpan(length));
                length += bytes.Length;
            }

            public byte[] ToArray()
            {
                return buffer.AsSpan(0, length).ToArray();
            }

            private void WriteByte(byte value)
            {
                EnsureCapacity(length + 1);
                buffer[length++] = value;
            }

            private void EnsureCapacity(int requiredLength)
            {
                if (requiredLength <= buffer.Length)
                {
                    return;
                }

                int newCapacity = Math.Max(requiredLength, buffer.Length * 2);
                Array.Resize(ref buffer, newCapacity);
            }
        }
    }
}
