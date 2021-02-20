using System;

namespace VisitorExercise
{
    public class ReverbFilter : IAudioFilter
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reverb filter on format segment.");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Reverb filter on fact segment.");
        }
    }
}
