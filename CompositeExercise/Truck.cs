using System;

namespace CompositeExercise
{
    public class Truck : Resource
    {
        public override void Deploy()
        {
            Console.WriteLine("Deploying a Truck.");
        }
    }
}
