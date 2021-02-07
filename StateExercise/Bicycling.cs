using System;

namespace StateExercise
{
    public class Bicycling : TravelModel
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (Bicycling)");
            return 1;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (Bicycling)");
            return 1;
        }
    }
}
