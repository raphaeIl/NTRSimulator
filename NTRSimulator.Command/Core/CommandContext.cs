using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Networking;

namespace NTRSimulator.Command;

public sealed class CommandContext
{
    public required CommandSource Source { get; init; }
    public Connection? Connection { get; init; }
    public required ILogger Logger { get; init; }
    public Action<string>? ClientReplyCallback { get; init; }
    public IReadOnlyDictionary<string, string> RawArgs { get; init; } = new Dictionary<string, string>();

    public void Reply(string message)
    {
        if (Source == CommandSource.Client && ClientReplyCallback is not null)
            ClientReplyCallback(message);

        Logger.LogInformation("[Cmd] {Message}", message);
    }
}
