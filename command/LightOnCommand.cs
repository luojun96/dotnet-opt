namespace command
{
    class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand()
        {
        }

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.On();
        }

        public void undo()
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
}