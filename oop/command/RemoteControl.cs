namespace command;
class RemoteControl
{
    ICommand? command;
    ICommand? undoCommand;

    public void SetCommand(ICommand remoteCommand)
    {
        command = remoteCommand;
        undoCommand = command;
    }

    public void ExecuteCommand()
    {
        command?.Execute();
    }

    public void UndoCommand()
    {
        undoCommand?.Undo();
    }
} 