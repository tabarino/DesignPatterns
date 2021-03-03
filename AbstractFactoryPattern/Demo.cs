using System;

namespace AbstractFactoryPattern
{
    public class Demo
    {
        public static void Show()
        {
            var winApplication = new Application(new WinFactory());
            winApplication.RenderButton();
            winApplication.RenderCheckbox();

            var macApplication = new Application(new MacFactory());
            macApplication.RenderButton();
            macApplication.RenderCheckbox();
        }
    }
}
