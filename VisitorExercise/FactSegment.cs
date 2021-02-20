using System;

namespace VisitorExercise
{
    public class FactSegment : Segment
    {
        public override void ApplyFilter(IAudioFilter filter)
        {
            filter.Apply(this);
        }
    }
}
