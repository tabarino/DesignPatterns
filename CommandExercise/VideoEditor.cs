using System;

namespace CommandExercise
{
    public class VideoEditor
    {
        public string Text { get; set; }
        public float Contrast { get; set; } = 0.5f;

        public override string ToString()
        {
            return $"VideoEditor - Contrast: {Contrast}, Text: {Text}.";
        }
    }
}
