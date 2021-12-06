using CommandPattern;
using MacroCommandPattern.Devices;

namespace MacroCommandPattern.Commands
{
    public class VacuumRobotCommand : ICommand
    {
        private readonly VacuumRobot _robot;

        public VacuumRobotCommand(VacuumRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.StartCleaning();
        }

        public void Revert()
        {
            _robot.StopCleaning();
        }
    }
}