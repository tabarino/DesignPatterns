using System;

namespace DesignPatterns
{
    public class DrawUIControl
    {
        public DrawUIControl(UIControl control)
        {
            control.Draw();
        }
    }
}
