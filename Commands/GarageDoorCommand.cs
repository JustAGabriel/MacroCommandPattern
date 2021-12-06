using CommandPattern;
using MacroCommandPattern.Devices;

namespace MacroCommandPattern.Commands
{
    public class GarageDoorCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.OpenGarageDoor();
        }

        public void Revert()
        {
            _garageDoor.CloseGarageDoor();
        }
    }
}