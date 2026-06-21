using System.Collections.Concurrent;
using System.Reflection;
using Google.Protobuf;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Protocol;

namespace NTRSimulator.Common.Packets
{
    public sealed class PacketDispatcher(
            IServiceProvider rootProvider,
            PacketHandlerRegistry registry,
            ILogger<PacketDispatcher> logger)
    {
        private readonly ConcurrentDictionary<Type, MessageParser> _parsers = new(); // TODO: Parser cache

        public void Dispatch(Connection connection, MainMessage message)
        {
            foreach (BasePacket packet in message.Packets)
            {
                this.Dispatch(connection, packet);
            }
        }

        public void Dispatch(Connection connection, BasePacket packet)
        {
            if (!registry.TryGet(packet.Header.MsgId, out var entry))
            {
                logger.LogWarning("No handler for {MsgId}; packet dropped", packet.Header.MsgId);
                return;
            }

            using var scope = rootProvider.CreateScope();
            var handler = scope.ServiceProvider.GetRequiredService(entry.Type);

            try
            {
                IMessage? request = packet.Message;
                object? result = entry.Method.Invoke(handler, new object?[] { request, connection });

                // If the handler maps to a reply MsgId, frame its returned message and send it.
                //if (entry.ReplyMsgId != MsgId.MsgNone && result is IMessage reply)
                //{
                //    connection.Send(new BasePacket(reply.ToByteArray()));
                //}
            }
            catch (TargetInvocationException ex) when (ex.InnerException is NotImplementedException notImplemented)
            {
                logger.LogWarning(notImplemented,
                    "Handler {Type}.{Method} was called for {MsgId} but is not implemented",
                    entry.Type.Name, entry.Method.Name, packet.MsgId);
            }
            catch (NotImplementedException ex)
            {
                logger.LogWarning(ex,
                    "Handler {Type}.{Method} was called for {MsgId} but is not implemented",
                    entry.Type.Name, entry.Method.Name, packet.MsgId);
            }
            catch (Exception ex)
            {
                var actual = (ex as TargetInvocationException)?.InnerException ?? ex;
                logger.LogError(actual, "Handler {Type}.{Method} failed for {MsgId}",
                    entry.Type.Name, entry.Method.Name, packet.MsgId);
            }
        }
    }
}
