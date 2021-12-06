using System;

namespace MacroCommandPattern.Devices
{
    public class Lamp
    {
        private bool _isOn { get; set; }

        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Light is on now.");
        }

        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Light is off now.");
        }
    }
}