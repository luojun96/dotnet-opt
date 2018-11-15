namespace command
{
    class LightRemoteControl
    {
        ICommand command;
        ICommand undoCommand;

        public void setCommand(ICommand lightCommand)
        {
            command = lightCommand;
        }

        public void ButtonWasPressed()
        {
            command.execute();
            undoCommand = command;
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.undo();
        }
    }
}