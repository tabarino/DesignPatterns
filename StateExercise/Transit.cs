using System;

namespace StateExercise
{
    public class Transit : TravelModel
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (Transit)");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (Transit)");
            return 3;
        }
    }
}
