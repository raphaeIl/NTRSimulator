using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace NTRSimulator.Command;

public sealed class ConsoleCommandHostedService(
    CommandDispatcher dispatcher,
    ILogger<ConsoleCommandHostedService> logger) : IHostedService
{
    private Thread? _readThread;
    private volatile bool _stopping;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _readThread = new Thread(ReadLoop) { IsBackground = true, Name = "Console-Commands" };
        _readThread.Start();
        return Task.CompletedTask;
    }

    private void ReadLoop()
    {
        logger.LogInformation("Console command input ready. Type 'help' for available commands.");

        while (!_stopping)
        {
            string? line;
            try
            {
                line = Console.ReadLine();
            }
            catch (IOException)
            {
                break;
            }

            if (line is null)
                break;

            if (string.IsNullOrWhiteSpace(line))
                continue;

            try
            {
                dispatcher.Dispatch(line.Trim(), CommandSource.Console);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Unhandled error dispatching console command");
            }
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _stopping = true;
        return Task.CompletedTask;
    }
}
