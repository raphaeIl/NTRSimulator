using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NTRSimulator.Database.Core
{
    public class NTRSimulatorDbContextFactory : IDesignTimeDbContextFactory<NTRSimulatorDbContext>
    {
        public NTRSimulatorDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connectionString = configuration.GetConnectionString("Postgres")
                ?? throw new InvalidOperationException("Connection string 'Postgres' not found.");

            PostgresDatabaseBootstrap.EnsureDatabaseExists(connectionString);

            var optionsBuilder = new DbContextOptionsBuilder<NTRSimulatorDbContext>();
            optionsBuilder.UseNpgsql(
                connectionString,
                npg => npg.MigrationsAssembly(typeof(NTRSimulatorDbContext).Assembly.FullName));

            return new NTRSimulatorDbContext(optionsBuilder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var basePath = FindAppSettingsDirectory();
            return new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .Build();
        }

        private static string FindAppSettingsDirectory()
        {
            var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (dir != null)
            {
                if (File.Exists(Path.Combine(dir.FullName, "appsettings.json")))
                    return dir.FullName;

                var nested = Path.Combine(dir.FullName, "NTRSimulator", "appsettings.json");
                if (File.Exists(nested))
                    return Path.Combine(dir.FullName, "NTRSimulator");

                dir = dir.Parent;
            }

            throw new InvalidOperationException("Could not find appsettings.json for design-time DbContext creation.");
        }
    }
}
