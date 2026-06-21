using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Hosting;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Packets;
using NTRSimulator.Common.Proto;
using NTRSimulator.Common.Protocol;
using NTRSimulator.PcapParser;
using Serilog;
using System.Reflection;

namespace NTRSimulator.GameServer
{
    public static class GameServerExtensions
    {
        public static IServiceCollection AddGameServer(this IServiceCollection services)
        {
            // Local copy is only used to enumerate handler types for registration below;
            // the resolvable singleton is registered via factory so it gets the host logger.
            var registry = new PacketHandlerRegistry(new[] { typeof(GameServerExtensions).Assembly });

            services.AddSingleton(sp => new PacketHandlerRegistry(
                new[] { typeof(GameServerExtensions).Assembly },
                sp.GetService<ILogger<PacketHandlerRegistry>>()));

            // Scoped so each handler is resolved inside the dispatcher's per-packet scope.
            foreach (var handlerType in registry.HandlerTypes)
                services.AddScoped(handlerType);

            RegisterScopedServicesByConvention(
                services,
                typeof(GameServerExtensions).Assembly);

            services.AddSingleton<PacketDispatcher>();
            services.AddSingleton<ConnectionManager>();

            services.AddHostedService<GameServerHostedService>();

             //var _ = PcapUtils.GetPacketFromPcap<SC_Guns>(MsgId.MsgScGuns, PacketType.RESPONSE);

            return services;
        }

        private static void RegisterScopedServicesByConvention(
            IServiceCollection services,
            Assembly assembly)
        {
            var allTypes = assembly.GetTypes();
            var serviceInterfaces = allTypes
                .Where(type => type.IsInterface)
                .Where(type => type != typeof(Services.IGameService))
                .Where(type => typeof(Services.IGameService).IsAssignableFrom(type));

            foreach (var serviceInterface in serviceInterfaces)
            {
                var implementation = allTypes.FirstOrDefault(type =>
                    type.IsClass
                    && !type.IsAbstract
                    && serviceInterface.IsAssignableFrom(type));

                if (implementation is not null)
                {
                    services.TryAddScoped(serviceInterface, implementation);
                    Log.Information("Registered GameService {ServiceInterface} -> {Implementation}", serviceInterface.Name, implementation.Name);
                }
            }
        }
    }
}
