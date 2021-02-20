using System;

namespace VisitorExercise
{
    public class FormatSegment : Segment
    {
        public override void ApplyFilter(IAudioFilter filter)
        {
            filter.Apply(this);
        }
    }
}
