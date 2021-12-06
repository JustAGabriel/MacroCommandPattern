using System;

namespace MacroCommandPattern.Devices
{
    public class GarageDoor
    {
        public void CloseGarageDoor() => Console.WriteLine("Garage door is closed now.");
        public void OpenGarageDoor() => Console.WriteLine("Garage door is open now.");
    }
}