using System;

namespace StateExercise
{
    public class Driving : TravelModel
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (Driving)");
            return 2;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (Driving)");
            return 2;
        }
    }
}
