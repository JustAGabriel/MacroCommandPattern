// See https://aka.ms/new-console-template for more information

using System;
using CommandPattern;
using MacroCommandPattern;
using MacroCommandPattern.Commands;
using MacroCommandPattern.Commands.MacroCommands;
using MacroCommandPattern.Devices;

Lamp lamp = new();
LampCommand lampCommand = new(lamp);

GarageDoor garageDoor = new();
GarageDoorCommand doorCommand = new(garageDoor);

VacuumRobot vacuumRobot = new();
VacuumRobotCommand vacuumRobotCommand = new(vacuumRobot);

PartyMacroCommand macroCommand =
    new(lampCommand, doorCommand, vacuumRobotCommand);

RemoteControl remote = new(macroCommand);
remote.ExecuteCommand();
Console.WriteLine("-----------------------------------");
remote.UndoCommand();
