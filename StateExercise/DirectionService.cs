using System;

namespace StateExercise
{
    public class DirectionService
    {
        private TravelModel _travelMode;

        public TravelModel TravelMode { get => _travelMode; set => _travelMode = value; }

        public object GetDirection()
        {
            return _travelMode.GetDirection();
        }

        public object GetEta()
        {
            return _travelMode.GetEta();
        }
    }
}
