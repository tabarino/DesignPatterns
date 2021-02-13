using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandExercise
{
    public class History
    {
        private IList<IUndoableCommand> _commands = new List<IUndoableCommand>();

        public int Count()
        {
            return _commands.Count;
        }

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var lastCommand = _commands.LastOrDefault();
            _commands.Remove(lastCommand);

            return lastCommand;
        }
    }
}
