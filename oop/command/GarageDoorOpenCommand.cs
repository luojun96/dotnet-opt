namespace command;
class GarageDoorOpenCommand : ICommand
{
    GarageDoor garageDoor;
    public GarageDoorOpenCommand(GarageDoor door)
    {
        this.garageDoor = door;
    }

    public void Execute()
    {
        garageDoor.Open();
    }

    public void Undo()
    {
        garageDoor.Close();
    }
}

class GarageDoor
{
    public void Open()
    {
        System.Console.WriteLine("Garage Door is open");
    }

    public void Close()
    {
        System.Console.WriteLine("Garage Door is closed");
    }
}