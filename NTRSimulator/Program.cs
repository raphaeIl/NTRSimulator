using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using NTRSimulator.Common.Proto;
using NTRSimulator.Database;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer;
using NTRSimulator.GameServer.Services;
using NTRSimulator.Command;
using NTRSimulator.SDKServer;
using NTRSimulator.Common.Table;
using Serilog;


namespace NTRSimulator
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateBootstrapLogger();

            try
            {
                Console.WriteLine(@"
                                                                               
                                                                               
                                                                               
 _   _ _____ ____  ____  _                 _       _                  
| \ | |_   _|  _ \/ ___|(_)_ __ ___  _   _| | __ _| |_ ___  _ __      
|  \| | | | | |_) \___ \| | '_ ` _ \| | | | |/ _` | __/ _ \| '__|     
| |\  | | | |  _ < ___) | | | | | | | |_| | | (_| | || (_) | |        
|_| \_| |_| |_| \_\____/|_|_| |_| |_|\__,_|_|\__,_|\__\___/|_|        
                                                                               
                                         


");
                Log.Information("Starting host...");

                var builder = WebApplication.CreateBuilder(args);

                builder.Host.UseSerilog((ctx, services, cfg) => cfg
                    .ReadFrom.Configuration(ctx.Configuration)
                    .WriteTo.Console());

                // Catch captive-dependency mistakes (scoped resolved from root) in dev.
                builder.Host.UseDefaultServiceProvider((ctx, opt) =>
                {
                    opt.ValidateScopes = ctx.HostingEnvironment.IsDevelopment();
                    opt.ValidateOnBuild = ctx.HostingEnvironment.IsDevelopment();
                });

                builder.Services.Configure<KestrelServerOptions>(o => o.AllowSynchronousIO = true);

                // ---- shared data layer (EF Core + Postgres) ----
                builder.Services.AddDataLayer(builder.Configuration);

                // ---- HTTP side: SDK login/config ----
                builder.Services.AddSdkServer();

                // ---- table loader: protobuf .bytes file loading + caching ----
                builder.Services.AddTableService();

                // ---- TCP side: the main game server (hosted background service) ----
                builder.Services.AddGameServer();

                // ---- Command system: attribute-driven commands from console & in-game chat ----
                builder.Services.AddCommandSystem();

                var app = builder.Build();

                // app.Services.GetService<ITableService>().DumpAllJsonToFile();
                // app.Services.GetService<ITableService>().PackAllJsonToFile();

                //List<GunData> gunData = app.Services.GetService<ITableService>().GetTable<GunData>();

                app.UseSerilogRequestLogging();
                app.UseAuthorization();
                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}