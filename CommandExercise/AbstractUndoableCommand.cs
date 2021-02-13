using System;

namespace CommandExercise
{
    // The purpose of this class is to make sure all undoable commands have
    // a VideoEditor and a History. Plus, whenever a command is executed,
    // it's pushed in the history. This way, we don't have to remember to
    // store each individual command in the history.
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        protected readonly VideoEditor _videoEditor;
        protected readonly History _history;

        protected AbstractUndoableCommand(VideoEditor videoEditor, History history)
        {
            _videoEditor = videoEditor;
            _history = history;
        }

        public void Execute()
        {
            // Another application of the template method pattern. This method
            // is defining a template for executing commands.
            DoExecute();

            _history.Push(this);
        }

        public abstract void Undo();

        protected abstract void DoExecute();
    }
}
