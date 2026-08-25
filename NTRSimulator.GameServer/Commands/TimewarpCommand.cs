using NTRSimulator.Command;
using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using System.Globalization;

namespace NTRSimulator.GameServer.Commands;

[Command("timewarp", "Set the in-game clock to a custom server time", "timewarp <serverTime> [uid] (or timewarp serverTime=<value> [uid=<value>])", CommandSource.All)]
public sealed class TimewarpCommand(ConnectionManager connectionManager) : ICommand
{
    [Argument("serverTime", "Unix timestamp (milliseconds) to use as in-game time", flags: ArgumentFlags.Optional)]
    public long ServerTime { get; set; }

    [Argument("uid", "Target player UID (required from console)", flags: ArgumentFlags.Optional)]
    public uint Uid { get; set; }

    public void Execute(CommandContext ctx)
    {
        if (!TryResolveArguments(ctx.RawArgs, out long requestedServerTime, out uint requestedUid, out string? argumentError))
        {
            ctx.Reply(argumentError!);
            return;
        }

        Connection? targetConnection = null;
        uint targetUid;

        if (ctx.Connection is not null)
        {
            if (ctx.Connection.Account is null)
            {
                ctx.Reply("Current connection does not have an authenticated account yet.");
                return;
            }

            targetConnection = ctx.Connection;
            targetUid = ctx.Connection.Account.Uid;
        }
        else
        {
            if (requestedUid == 0)
            {
                ctx.Reply("Console usage requires a target uid. Usage: timewarp <serverTime> <uid>");
                return;
            }

            targetUid = requestedUid;
            foreach (Connection connection in connectionManager.Connections)
            {
                if (connection.Account?.Uid == targetUid)
                {
                    targetConnection = connection;
                    break;
                }
            }

            if (targetConnection is null)
            {
                ctx.Reply($"No online connection found for uid {targetUid}.");
                return;
            }
        }

        targetConnection.ServerTimeOverride = requestedServerTime;
        targetConnection.Send(new SC_Sync
        {
            Timestamp = requestedServerTime,
            ActiveTime = 0
        });

        ctx.Reply($"Set in-game server time to {requestedServerTime} for uid {targetUid}.");
    }

    private bool TryResolveArguments(
        IReadOnlyDictionary<string, string> rawArgs,
        out long serverTime,
        out uint uid,
        out string? error)
    {
        serverTime = ServerTime;
        uid = Uid;
        error = null;
        bool hasServerTime = rawArgs.ContainsKey("serverTime");

        if (rawArgs.TryGetValue("serverTime", out string? namedServerTime))
        {
            if (!long.TryParse(namedServerTime, NumberStyles.Integer, CultureInfo.InvariantCulture, out serverTime))
            {
                error = $"Invalid serverTime value '{namedServerTime}'.";
                return false;
            }
        }

        if (rawArgs.TryGetValue("uid", out string? namedUid))
        {
            if (!uint.TryParse(namedUid, NumberStyles.Integer, CultureInfo.InvariantCulture, out uid))
            {
                error = $"Invalid uid value '{namedUid}'.";
                return false;
            }
        }

        List<string> positionalNumbers = [];
        foreach (KeyValuePair<string, string> entry in rawArgs)
        {
            if (entry.Key.Equals("serverTime", StringComparison.OrdinalIgnoreCase)
                || entry.Key.Equals("uid", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (!string.Equals(entry.Value, "true", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (long.TryParse(entry.Key, NumberStyles.Integer, CultureInfo.InvariantCulture, out _))
            {
                positionalNumbers.Add(entry.Key);
            }
        }

        if (serverTime == 0 && positionalNumbers.Count > 0)
        {
            if (!long.TryParse(positionalNumbers[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out serverTime))
            {
                error = $"Invalid serverTime value '{positionalNumbers[0]}'.";
                return false;
            }

            hasServerTime = true;
        }

        if (uid == 0 && positionalNumbers.Count > 1)
        {
            if (!uint.TryParse(positionalNumbers[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out uid))
            {
                error = $"Invalid uid value '{positionalNumbers[1]}'.";
                return false;
            }
        }

        if (!hasServerTime)
        {
            error = "Missing required argument: serverTime. Usage: timewarp <serverTime> [uid]";
            return false;
        }

        return true;
    }
}
