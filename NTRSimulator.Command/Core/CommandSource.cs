namespace NTRSimulator.Command;

[Flags]
public enum CommandSource
{
    None    = 0,
    Console = 1 << 0,
    Client  = 1 << 1,
    All     = Console | Client,
}
