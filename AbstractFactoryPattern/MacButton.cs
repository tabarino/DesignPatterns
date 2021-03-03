using System;

namespace AbstractFactoryPattern
{
    // Concrete products are created by corresponding concrete factories.
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a button in MacOS style.");
        }
    }
}
