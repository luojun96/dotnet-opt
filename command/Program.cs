using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            LightRemoteControl control = new LightRemoteControl();
            LightOnCommand lightCommand = new LightOnCommand(new Light());
            control.setCommand(lightCommand);
            control.ButtonWasPressed();

            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(new GarageDoor());
            control.setCommand(garageDoorOpenCommand);
            control.ButtonWasPressed();
            control.UndoButtonWasPressed();

            ICommand[] commands = { lightCommand, garageDoorOpenCommand };
            MacroCommand macroCommand = new MacroCommand(commands);
            control.setCommand(macroCommand);
            control.ButtonWasPressed();
        
        }
    }
}
