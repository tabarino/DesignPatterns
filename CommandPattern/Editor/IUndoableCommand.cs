using System;

namespace CommandPattern.Editor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
