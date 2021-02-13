using System;

namespace CommandExercise
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}
