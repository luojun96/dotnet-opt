namespace command;

interface ICommand 
{
    void Execute();

    void Undo();
}