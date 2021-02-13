using System;

namespace CommandExercise
{
    public class SetTextCommand : AbstractUndoableCommand
    {
        private readonly string _text;

        public SetTextCommand(string text, VideoEditor videoEditor, History history)
            : base(videoEditor, history)
        {
            _text = text;
        }

        protected override void DoExecute()
        {
            base._videoEditor.Text = _text;
        }

        public override void Undo()
        {
            base._videoEditor.Text = "";
        }
    }
}
