using Microsoft.Extensions.DependencyInjection;

namespace NTRSimulator.Command;

public static class CommandServiceExtensions
{
    public static IServiceCollection AddCommandSystem(this IServiceCollection services)
    {
        foreach (var type in CommandRegistry.DiscoverCommandTypes())
            services.AddScoped(type);

        services.AddSingleton<CommandRegistry>();
        services.AddSingleton<CommandDispatcher>();
        services.AddHostedService<ConsoleCommandHostedService>();

        return services;
    }
}
