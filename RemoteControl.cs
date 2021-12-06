using System;
using System.Collections.Generic;
using CommandPattern;

namespace MacroCommandPattern
{
    public class RemoteControl
    {
        private readonly Queue<ICommand> _commandQueue;
        private ICommand _previousCommand;

        public RemoteControl(params ICommand[] commands)
        {
            _commandQueue = new Queue<ICommand>(commands);
        }

        public void ExecuteCommand()
        {
            if (_commandQueue.Count <= 0)
            {
                Console.WriteLine("No commands left to execute.");
                return;
            }

            var command = _commandQueue.Dequeue();
            _previousCommand = command;
            command.Execute();
        }

        public void UndoCommand()
        {
            if (_previousCommand is null)
            {
                Console.WriteLine("No command was executed yet.");
                return;
            }

            _previousCommand.Revert();
        }
    }
}