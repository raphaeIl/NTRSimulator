using System.Reflection;
using System.Text.RegularExpressions;

namespace NTRSimulator.Command;

public sealed record CommandRegistration(
    string Name,
    string Description,
    string Usage,
    CommandSource AllowedSources,
    Type CommandType,
    IReadOnlyList<ArgumentRegistration> Arguments);

public sealed record ArgumentRegistration(
    string Name,
    string Description,
    bool Required,
    ArgumentFlags Flags,
    Regex Pattern,
    PropertyInfo Property);
