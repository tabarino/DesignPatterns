using System;

namespace FactoryMethodPattern
{
    public class HtmlButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Return an HTML representation of a button.");
        }

        public void OnClick()
        {
            Console.WriteLine("Bind a web browser click event.");
        }
    }
}
