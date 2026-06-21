namespace NTRSimulator.Command;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class CommandAttribute : Attribute
{
    public string Name { get; }
    public string Description { get; }
    public string Usage { get; }
    public CommandSource AllowedSources { get; }

    public CommandAttribute(
        string name,
        string description,
        string usage = "",
        CommandSource allowedSources = CommandSource.All)
    {
        Name = name;
        Description = description;
        Usage = usage;
        AllowedSources = allowedSources;
    }
}
