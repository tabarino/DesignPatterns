using System;

namespace VisitorExercise
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(IAudioFilter filter);
    }
}
