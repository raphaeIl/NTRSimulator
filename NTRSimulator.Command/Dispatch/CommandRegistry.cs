using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace NTRSimulator.Command;

public sealed class CommandRegistry
{
    private readonly Dictionary<string, CommandRegistration> _commands = new(StringComparer.OrdinalIgnoreCase);

    public CommandRegistry(ILogger<CommandRegistry>? logger = null)
    {
        foreach (var type in DiscoverCommandTypes())
        {
            var attr = type.GetCustomAttribute<CommandAttribute>()!;

            var args = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(p => (Prop: p, Attr: p.GetCustomAttribute<ArgumentAttribute>()))
                .Where(x => x.Attr is not null)
                .Select(x =>
                {
                    var regexOptions = (x.Attr!.Flags & ArgumentFlags.IgnoreCase) != 0
                        ? RegexOptions.IgnoreCase | RegexOptions.Compiled
                        : RegexOptions.Compiled;
                    var pattern = new Regex($"^(?:{x.Attr.Pattern})$", regexOptions);
                    return new ArgumentRegistration(x.Attr.Name, x.Attr.Description, x.Attr.Required, x.Attr.Flags, pattern, x.Prop);
                })
                .ToList();

            var reg = new CommandRegistration(attr.Name, attr.Description, attr.Usage, attr.AllowedSources, type, args);

            if (!_commands.TryAdd(attr.Name, reg))
            {
                logger?.LogWarning("Duplicate command name '{Name}'; {Type} ignored", attr.Name, type.Name);
                continue;
            }

            logger?.LogInformation("Registered command '{Name}' -> {Type}", attr.Name, type.Name);
        }
    }

    public static IEnumerable<Type> DiscoverCommandTypes()
        => AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => { try { return a.GetTypes(); } catch { return []; } })
            .Where(t => !t.IsAbstract && !t.IsInterface
                && t.GetCustomAttribute<CommandAttribute>() is not null
                && typeof(ICommand).IsAssignableFrom(t));

    public bool TryGet(string name, out CommandRegistration registration)
        => _commands.TryGetValue(name, out registration!);

    public IEnumerable<CommandRegistration> GetAll() => _commands.Values;
}

