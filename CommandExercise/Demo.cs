using System;

namespace CommandExercise
{
    public class Demo
    {
        public static void Show()
        {
            var videoEditor = new VideoEditor();
            var history = new History();

            var setTextCommand = new SetTextCommand("Video Title", videoEditor, history);
            setTextCommand.Execute();
            Console.WriteLine($"Text: {videoEditor}");

            var setContrast = new SetContrastCommand(1, videoEditor, history);
            setContrast.Execute();
            Console.WriteLine($"Contrast: {videoEditor}");

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine($"Undo: {videoEditor}");

            undoCommand.Execute();
            Console.WriteLine($"Undo: {videoEditor}");

            undoCommand.Execute();
            Console.WriteLine($"Undo: {videoEditor}");
        }
    }
}
