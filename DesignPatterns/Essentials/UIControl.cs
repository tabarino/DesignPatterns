using System;

namespace DesignPatterns
{
    public abstract class UIControl
    {
        public void Enable()
        {
            Console.WriteLine("Enabled");
        }

        public abstract void Draw();
    }
}
