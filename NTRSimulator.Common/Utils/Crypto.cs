namespace NTRSimulator.Common.Utils
{
    public static class Crypto
    {
        public static byte[] XorCrypt(ReadOnlySpan<byte> data, ReadOnlySpan<byte> key)
        {
            if (key.IsEmpty)
            {
                throw new ArgumentException("Key cannot be empty.", nameof(key));
            }

            byte[] output = GC.AllocateUninitializedArray<byte>(data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                output[i] = (byte)(data[i] ^ key[i % key.Length]);
            }

            return output;
        }
    }
}
