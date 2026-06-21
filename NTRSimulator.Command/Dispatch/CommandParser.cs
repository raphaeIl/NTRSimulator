using System.Text;

namespace NTRSimulator.Command;

public static class CommandParser
{
    public static (string? CommandName, Dictionary<string, string> Args) Parse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return (null, new());

        var tokens = Tokenize(input);
        if (tokens.Count == 0)
            return (null, new());

        var name = tokens[0];
        var args = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        for (int i = 1; i < tokens.Count; i++)
        {
            var eqIndex = tokens[i].IndexOf('=');
            if (eqIndex > 0)
                args[tokens[i][..eqIndex]] = tokens[i][(eqIndex + 1)..];
            else
                args[tokens[i]] = "true";
        }

        return (name, args);
    }

    private static List<string> Tokenize(string input)
    {
        var tokens = new List<string>();
        var current = new StringBuilder();
        bool inQuotes = false;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (c == '"')
            {
                inQuotes = !inQuotes;
                continue;
            }

            if (c == ' ' && !inQuotes)
            {
                if (current.Length > 0)
                {
                    tokens.Add(current.ToString());
                    current.Clear();
                }
                continue;
            }

            current.Append(c);
        }

        if (current.Length > 0)
            tokens.Add(current.ToString());

        return tokens;
    }
}
