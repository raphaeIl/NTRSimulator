using NTRSimulator.Common.Manager;
using NTRSimulator.SDKServer.Controllers;
using NTRSimulator.SDKServer.Services;

namespace NTRSimulator.SDKServer
{
    public static class SdkServerExtensions
    {
        public static IServiceCollection AddSdkServer(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();

            services.AddControllers()
                    .AddApplicationPart(typeof(SDKController).Assembly);

            return services;
        }
    }
}
