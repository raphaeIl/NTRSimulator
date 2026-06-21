namespace NTRSimulator.Command;

public static class CommandUsageFormatter
{
    public static string BuildSyntax(CommandRegistration reg)
    {
        if (!string.IsNullOrWhiteSpace(reg.Usage))
            return reg.Usage;

        var parts = new List<string> { reg.Name };

        foreach (var arg in reg.Arguments)
        {
            parts.Add(arg.Required ? $"<{arg.Name}>" : $"[{arg.Name}]");
        }

        return string.Join(' ', parts);
    }
}
