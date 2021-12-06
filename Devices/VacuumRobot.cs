using System;

namespace MacroCommandPattern.Devices
{
    public class VacuumRobot
    {
        public void StartCleaning() => Console.WriteLine("Vacuum robot started it's work.");
        public void StopCleaning() => Console.WriteLine("Vacuum robot stopped it's work.");
    }
}