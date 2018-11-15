namespace command
{
    interface ICommand {
        void execute();

        void undo();
    }
}