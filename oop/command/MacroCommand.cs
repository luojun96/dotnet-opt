namespace command
{
    class MacroCommand : ICommand
    {
        ICommand[] commands;
        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var item in commands)
            {
                item.Execute();
            }
        }

        public void Undo()
        {
            foreach (var item in commands)
            {
                item.Undo();
            }
        }
    }
}