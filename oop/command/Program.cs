// See https://aka.ms/new-console-template for more information
using command;

Console.WriteLine("Hello, World!");

RemoteControl remote = new RemoteControl();
GarageDoorOpenCommand command = new GarageDoorOpenCommand(new GarageDoor());
remote.SetCommand(command);
remote.ExecuteCommand();

LightOnCommand lightCommand = new LightOnCommand(new Light());
remote.SetCommand(lightCommand);
remote.ExecuteCommand();


MacroCommand macroCommand = new MacroCommand(new ICommand[] { command, lightCommand });
remote.SetCommand(macroCommand);
remote.ExecuteCommand();
remote.UndoCommand();