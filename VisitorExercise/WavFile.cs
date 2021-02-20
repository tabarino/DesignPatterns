using System;
using System.Collections.Generic;

namespace VisitorExercise
{
    public class WavFile
    {
        private IList<Segment> _segments = new List<Segment>();

        public static WavFile Read(string filename)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile._segments.Add(new FormatSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());
            wavFile._segments.Add(new FactSegment());

            return wavFile;
        }

        public void ApplyFilter(IAudioFilter filter)
        {
            foreach (var segment in _segments)
            {
                segment.ApplyFilter(filter);
            }
        }
    }
}
