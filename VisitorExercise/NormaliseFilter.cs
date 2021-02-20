using System;

namespace VisitorExercise
{
    public class NormaliseFilter : IAudioFilter
    {
        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalise on format segment.");
        }

        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalise on fact segment.");
        }
    }
}
