using Microsoft.Extensions.DependencyInjection;

namespace NTRSimulator.Common.Table
{
    public static class TableExtensions
    {
        public static IServiceCollection AddTableService(
            this IServiceCollection services)
        {
            services.AddSingleton<ITableService, TableService>();
            return services;
        }
    }
}
