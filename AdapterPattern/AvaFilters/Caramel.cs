using System;

namespace AdapterPattern.AvaFilters
{
    public class Caramel
    {
        public void Init()
        {
            Console.WriteLine("Initialise Caramel Filter.");
        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter.");
        }
    }
}
