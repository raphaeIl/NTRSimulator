namespace NTRSimulator.Command;

public interface ICommand
{
    void Execute(CommandContext context);
}
