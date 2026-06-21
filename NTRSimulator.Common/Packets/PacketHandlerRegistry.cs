using System.Reflection;
using Google.Protobuf;
using Microsoft.Extensions.Logging;

using NTRSimulator.Common.Protocol;

namespace NTRSimulator.Common.Packets
{
    public sealed class PacketHandlerRegistry
    {
        private readonly Dictionary<MsgId, HandlerEntry> _map = new();

        public PacketHandlerRegistry(IEnumerable<Assembly> handlerAssemblies, ILogger<PacketHandlerRegistry>? logger = null)
        {
            var handlerTypes = handlerAssemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IPacketHandler).IsAssignableFrom(t)
                            && t is { IsInterface: false, IsAbstract: false });

            foreach (var type in handlerTypes)
            {
                foreach (var method in type.GetMethods())
                {
                    var attr = method.GetCustomAttribute<PacketHandlerAttribute>(inherit: true)
                               ?? method.GetBaseDefinition().GetCustomAttribute<PacketHandlerAttribute>(inherit: false);
                    if (attr is null)
                        continue;

                    var requestType = method.GetParameters().Length > 0
                        ? method.GetParameters()[0].ParameterType
                        : null;

                    if (requestType is not null && !typeof(IMessage).IsAssignableFrom(requestType))
                    {
                        throw new InvalidOperationException(
                            $"{type.Name}.{method.Name} maps {attr.ReqMsgId} but its request parameter " +
                            $"'{requestType.Name}' does not implement {nameof(IMessage)}; " +
                            "packet handlers must take a protobuf message as their first parameter.");
                    }

                    var entry = new HandlerEntry(type, method, requestType, attr.RespMsgId);
                    if (!_map.TryAdd(attr.ReqMsgId, entry))
                    {
                        logger?.LogWarning("Duplicate handler for {MsgId}; {Type}.{Method} ignored",
                            attr.ReqMsgId, type.Name, method.Name);
                        continue;
                    }

                    logger?.LogInformation("Mapped {MsgId} -> {Type}.{Method} (reply: {Reply})",
                        attr.ReqMsgId, type.Name, method.Name, attr.RespMsgId);
                }
            }
        }

        public bool TryGet(MsgId msgId, out HandlerEntry entry) => _map.TryGetValue(msgId, out entry);

        public IEnumerable<Type> HandlerTypes => _map.Values.Select(e => e.Type).Distinct();
    }

    public readonly record struct HandlerEntry(Type Type, MethodInfo Method, Type? RequestType, MsgId ReplyMsgId);
}