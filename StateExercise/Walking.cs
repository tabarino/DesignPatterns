using System;

namespace StateExercise
{
    public class Walking : TravelModel
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (Walking)");
            return 4;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (Walking)");
            return 4;
        }
    }
}
