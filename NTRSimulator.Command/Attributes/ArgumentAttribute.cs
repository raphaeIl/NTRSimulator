namespace NTRSimulator.Command;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public sealed class ArgumentAttribute : Attribute
{
    public string Name { get; }
    public string Description { get; }

    /// <summary>
    /// Regex pattern the argument value must match. Defaults to <c>".*"</c> (accept anything).
    /// </summary>
    public string Pattern { get; }
    public ArgumentFlags Flags { get; }
    public bool Required => (Flags & ArgumentFlags.Optional) == 0;

    public ArgumentAttribute(
        string name,
        string description = "",
        string pattern = ".*",
        ArgumentFlags flags = ArgumentFlags.None)
    {
        Name = name;
        Description = description;
        Pattern = pattern;
        Flags = flags;
    }
}
