using System;

namespace CompositeExercise
{
    public class HumanResource : Resource
    {
        public override void Deploy()
        {
            Console.WriteLine("Deploying a Human Resource.");
        }
    }
}
