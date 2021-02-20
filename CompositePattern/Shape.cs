using System;

namespace CompositePattern
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Render Shape");
        }

        public void Move()
        {
            Console.WriteLine("Move Shape");
        }
    }
}
