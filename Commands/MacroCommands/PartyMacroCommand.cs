using System.Linq;
using CommandPattern;

namespace MacroCommandPattern.Commands.MacroCommands
{
    public class PartyMacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public PartyMacroCommand(params ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Revert()
        {
            foreach (var command in _commands.Reverse())
            {
                command.Revert();    
            }
        }
    }
}