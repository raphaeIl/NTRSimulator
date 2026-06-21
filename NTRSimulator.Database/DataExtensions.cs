using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NTRSimulator.Database.Core;
using NTRSimulator.Database.Repositories;
using NTRSimulator.Database.Services;
using Serilog;
using System.Reflection;

namespace NTRSimulator.Database
{
    public static class DataExtensions
    {
        public static IServiceCollection AddDataLayer(
            this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("Postgres")
                ?? throw new InvalidOperationException("Connection string 'Postgres' not found.");

            PostgresDatabaseBootstrap.EnsureDatabaseExists(connectionString);

            services.AddDbContext<NTRSimulatorDbContext>(opt =>
                opt.UseNpgsql(
                    connectionString,
                    npg => npg.MigrationsAssembly(typeof(NTRSimulatorDbContext).Assembly.FullName))
                    .UseLazyLoadingProxies());

            RegisterRepositories(services, typeof(GunRepository).Assembly);
            services.AddScoped<IAccountService, AccountService>();

            var optionsBuilder = new DbContextOptionsBuilder<NTRSimulatorDbContext>();
            optionsBuilder.UseNpgsql(
                connectionString,
                npg => npg.MigrationsAssembly(typeof(NTRSimulatorDbContext).Assembly.FullName));
            using var db = new NTRSimulatorDbContext(optionsBuilder.Options);
            db.Database.Migrate();

            return services;
        }

        private static void RegisterRepositories(
            IServiceCollection services,
            Assembly assembly)
        {
            var allTypes = assembly.GetTypes();
            var repositoryInterfaces = allTypes
                .Where(type => type.IsInterface)
                .Where(type => type.GetInterfaces().Any(IsRepositoryInterface));

            foreach (var repositoryInterface in repositoryInterfaces)
            {
                var implementation = allTypes.FirstOrDefault(type =>
                    type.IsClass
                    && !type.IsAbstract
                    && repositoryInterface.IsAssignableFrom(type));

                if (implementation is not null)
                {
                    services.TryAddScoped(repositoryInterface, implementation);
                    Log.Information("Registered Repository {RepositoryInterface} -> {Implementation}", repositoryInterface.Name, implementation.Name);
                }
            }
        }

        private static bool IsRepositoryInterface(Type type)
            => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IRepository<>);
    }
}
