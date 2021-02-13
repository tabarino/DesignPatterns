using System;

namespace CommandExercise
{
    public class SetContrastCommand : AbstractUndoableCommand
    {
        private readonly float _prevContrast;
        private readonly float _contrast;

        public SetContrastCommand(float contrast, VideoEditor videoEditor, History history)
            : base(videoEditor, history)
        {
            _prevContrast = videoEditor.Contrast;
            _contrast = contrast;
        }

        protected override void DoExecute()
        {
            base._videoEditor.Contrast = _contrast;
        }

        public override void Undo()
        {
            base._videoEditor.Contrast = _prevContrast;
        }
    }
}
