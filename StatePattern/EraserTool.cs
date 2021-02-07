using System;

namespace StatePattern
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
