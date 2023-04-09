public class CarShopMacroCommand : ICommand
{
    private readonly List<ICommand> _commands;

    public CarShopMacroCommand(List<ICommand> commands)
    {
        _commands = commands;
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in _commands.Reverse())
        {
            command.Undo();
        }
    }
}