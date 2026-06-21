namespace NTRSimulator.Common.Utils
{
    public static class HexUtils
    {
        public static string FormatBytes(byte[] bytes)
        {
            ArgumentNullException.ThrowIfNull(bytes);
            return BitConverter.ToString(bytes).Replace("-", " ");
        }

        public static byte[] RecalculateMainMessageLength(byte[] rawMainMessage)
        {
            ArgumentNullException.ThrowIfNull(rawMainMessage);

            const int headerLength = 5;
            if (rawMainMessage.Length < headerLength)
            {
                throw new ArgumentException("Raw main message must include the 5-byte main message header.", nameof(rawMainMessage));
            }

            int bodyLength = rawMainMessage.Length - headerLength;
            if (bodyLength > ushort.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(rawMainMessage), "Main message body length cannot exceed 65535 bytes.");
            }

            byte[] recalculated = rawMainMessage.ToArray();
            byte encryptionFlag = recalculated[4];
            byte lengthHigh = (byte)(bodyLength >> 8);
            byte lengthLow = (byte)bodyLength;

            if (encryptionFlag > 0)
            {
                lengthHigh ^= encryptionFlag;
            }

            recalculated[2] = lengthHigh;
            recalculated[3] = lengthLow;

            return recalculated;
        }

        public static byte[] ParseHexStream(string hexStream)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(hexStream);

            char[] normalized = new char[hexStream.Length];
            int writeOffset = 0;

            for (int i = 0; i < hexStream.Length; i++)
            {
                char current = hexStream[i];
                if (char.IsWhiteSpace(current) || current == '-' || current == '_')
                {
                    continue;
                }

                if (current == '0' && i + 1 < hexStream.Length && (hexStream[i + 1] == 'x' || hexStream[i + 1] == 'X'))
                {
                    i++;
                    continue;
                }

                normalized[writeOffset++] = current;
            }

            if (writeOffset == 0)
            {
                throw new ArgumentException("Hex stream must contain at least one byte.", nameof(hexStream));
            }

            if (writeOffset % 2 != 0)
            {
                throw new FormatException("Hex stream must contain an even number of hex digits.");
            }

            return Convert.FromHexString(normalized.AsSpan(0, writeOffset));
        }
    }
}
