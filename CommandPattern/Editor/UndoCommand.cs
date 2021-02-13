using System;

namespace CommandPattern.Editor
{
    public class UndoCommand : ICommand
    {
        private readonly History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Count() > 0)
            {
                _history.Pop().Unexecute();
            }
        }
    }
}
