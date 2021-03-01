using System;

namespace FactoryMethodPattern
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render a button in Windows style.");
        }

        public void OnClick()
        {
            Console.WriteLine("Bind a native OS click event.");
        }
    }
}
