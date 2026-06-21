using System.Net.Sockets;

namespace NTRSimulator.Common.Protocol
{
    public static class PacketFramer
    {
        public const ushort HeaderLength = MainMessage.HeaderLength;

        private const int ClientSocketChunkSize = 1024;

        public static MainMessage? Read(Stream stream)
        {
            var headerBytes = new byte[HeaderLength];
            
            if (!ReadExactlyOrEof(stream, headerBytes))
            {
                return null;
            }

            ushort messageLength = MainMessage.CalculateMainMessageLength(headerBytes);
            byte[]? bodyBytes = new byte[messageLength];

            if (!ReadExactlyOrEof(stream, bodyBytes))
            {
                return null;
            }

            byte[] rawMessageBytes = headerBytes.Concat(bodyBytes).ToArray();

            MainMessage message = new(rawMessageBytes);

            return message;
        }

        public static void WriteClientSizedChunks(NetworkStream stream, byte[] data)
        {
            int offset = 0;
            while (offset < data.Length)
            {
                int chunkLength = Math.Min(ClientSocketChunkSize, data.Length - offset);
                stream.Write(data, offset, chunkLength);
                offset += chunkLength;
            }
        }

        // Returns false on EOF or remote hang-up at a frame boundary; throws if the stream ends mid-frame.
        private static bool ReadExactlyOrEof(Stream stream, Span<byte> buffer)
        {
            int read = 0;
            while (read < buffer.Length)
            {
                int n;
                try
                {
                    n = stream.Read(buffer[read..]);
                }
                catch (IOException ex) when (IsRemoteDisconnect(ex))
                {
                    return false;
                }

                if (n == 0)
                {
                    if (read == 0) return false;
                    throw new EndOfStreamException("Stream ended mid-frame.");
                }
                read += n;
            }
            return true;
        }

        private static bool IsRemoteDisconnect(IOException ex) =>
            ex.InnerException is SocketException { SocketErrorCode: var code }
            && code is SocketError.ConnectionReset
                or SocketError.ConnectionAborted
                or SocketError.Shutdown
                or SocketError.OperationAborted;
    }
}
