using System;
using System.Collections.Generic;
using CommandPattern.Fx;

namespace CommandPattern
{
    public class CompositeCommand : ICommand
    {
        private IList<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
