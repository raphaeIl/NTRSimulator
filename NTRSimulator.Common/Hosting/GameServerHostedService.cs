using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Packets;
using NTRSimulator.Common.Protocol;

namespace NTRSimulator.Common.Hosting
{
    public sealed class GameServerHostedService(
           PacketDispatcher dispatcher,
           ConnectionManager connections,
           IConfiguration config,
           ILoggerFactory loggerFactory) : IHostedService
    {
        private readonly ILogger<GameServerHostedService> _logger = loggerFactory.CreateLogger<GameServerHostedService>();
        private readonly int _port = config.GetValue("GameServer:Port", 7001);

        private TcpListener? _listener;
        private Thread? _acceptThread;
        private volatile bool _stopping;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();
            _logger.LogInformation("GameServer listening on port {Port}", _port);

            _acceptThread = new Thread(AcceptLoop) { IsBackground = true, Name = "GameServer-Accept" };
            _acceptThread.Start();
            return Task.CompletedTask;
        }

        private void AcceptLoop()
        {
            var connectionLogger = loggerFactory.CreateLogger<Connection>();

            try
            {
                while (!_stopping)
                {
                    TcpClient client = _listener!.AcceptTcpClient();

                    var connection = new Connection(
                        client, dispatcher, connections, connectionLogger);

                    var thread = new Thread(connection.Run) { IsBackground = true };
                    thread.Start();
                }
            }
            catch (SocketException) when (_stopping)
            {
                // listener stopped during shutdown
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _stopping = true;

            _logger.LogInformation("GameServer stopping; closing {Count} connection(s)", connections.Count);
            foreach (var connection in connections.Connections)
                connection.Close();

            _listener?.Stop();
            return Task.CompletedTask;
        }
    }
}