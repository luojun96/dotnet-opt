namespace command;

class LightOnCommand : ICommand
{
    private Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }
    public void Execute()
    {
        light.On();
    }

    public void Undo()
    {
        light.Off();
    }
}

class Light
{
    public void On()
    {
        System.Console.WriteLine("Light is on");
    }

    public void Off()
    {
        System.Console.WriteLine("Light is off");
    }
}