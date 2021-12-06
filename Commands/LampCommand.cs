using MacroCommandPattern;
using MacroCommandPattern.Devices;

namespace CommandPattern
{
    public class LampCommand : ICommand
    {
        private readonly Lamp _lamp;

        public LampCommand(Lamp lamp)
        {
            _lamp = lamp;
        }

        public void Execute()
        {
            _lamp.TurnOn();
        }

        public void Revert()
        {
            _lamp.TurnOff();
        }
    }
}