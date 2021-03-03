using System;

namespace AbstractFactoryPattern
{
    // Concrete checkbox are created by corresponding concrete factories.
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Render a checkbox in MacOS style.");
        }
    }
}
