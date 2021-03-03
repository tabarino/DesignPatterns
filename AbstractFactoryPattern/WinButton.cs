using System;

namespace AbstractFactoryPattern
{
    // Concrete products are created by corresponding concrete factories.
    public class WinButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a button in Windows style.");
        }
    }
}
