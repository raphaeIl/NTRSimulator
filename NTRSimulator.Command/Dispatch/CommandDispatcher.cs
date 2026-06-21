using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Networking;

namespace NTRSimulator.Command;

public sealed class CommandDispatcher(
    IServiceProvider rootProvider,
    CommandRegistry registry,
    ILogger<CommandDispatcher> logger)
{
    public void Dispatch(
        string input,
        CommandSource source,
        Connection? connection = null,
        Action<string>? clientReplyCallback = null)
    {
        var (name, rawArgs) = CommandParser.Parse(input);
        if (name is null)
            return;

        if (!registry.TryGet(name, out var reg))
        {
            var msg = $"Unknown command: {name}. Type 'help' for available commands.";
            logger.LogWarning("{Message}", msg);

            if (source == CommandSource.Client && clientReplyCallback is not null)
                clientReplyCallback(msg);

            return;
        }

        if (!reg.AllowedSources.HasFlag(source))
        {
            var msg = $"Command '{name}' is not available from {source}.";
            logger.LogWarning("{Message}", msg);

            if (source == CommandSource.Client && clientReplyCallback is not null)
                clientReplyCallback(msg);

            return;
        }

        using var scope = rootProvider.CreateScope();
        var command = (ICommand)scope.ServiceProvider.GetRequiredService(reg.CommandType);

        var context = new CommandContext
        {
            Source = source,
            Connection = connection,
            Logger = logger,
            ClientReplyCallback = clientReplyCallback,
            RawArgs = rawArgs,
        };

        var bindError = TryBindArguments(command, reg, rawArgs);
        if (bindError is not null)
        {
            context.Reply($"{bindError}, Usage: {CommandUsageFormatter.BuildSyntax(reg)}");
            return;
        }

        try
        {
            command.Execute(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Command '{Name}' failed", name);
            context.Reply($"Error: {ex.Message}");
        }
    }

    private static string? TryBindArguments(ICommand command, CommandRegistration reg, Dictionary<string, string> rawArgs)
    {
        foreach (var argReg in reg.Arguments)
        {
            if (rawArgs.TryGetValue(argReg.Name, out var rawValue))
            {
                if (!argReg.Pattern.IsMatch(rawValue))
                {
                    return $"Argument '{argReg.Name}' value '{rawValue}' does not match pattern \"{argReg.Pattern}\".";
                }

                var converter = TypeDescriptor.GetConverter(argReg.Property.PropertyType);
                if (converter.CanConvertFrom(typeof(string)))
                {
                    var converted = converter.ConvertFromInvariantString(rawValue);
                    argReg.Property.SetValue(command, converted);
                }
                else
                {
                    return $"Cannot convert value '{rawValue}' to type '{argReg.Property.PropertyType.Name}' for argument '{argReg.Name}'.";
                }
            }
            else if (argReg.Required)
            {
                return $"Missing required argument: {argReg.Name}";
            }
        }

        return null;
    }
}
