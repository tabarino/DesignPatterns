using System;

namespace VisitorExercise
{
    public interface IAudioFilter
    {
        void Apply(FormatSegment formatSegment);
        void Apply(FactSegment factSegment);
    }
}
