using System;

namespace AdapterPattern
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter.");
        }
    }
}
