using System;

namespace FactoryMethodPattern
{
    public class Demo
    {
        public static void Show()
        {
            var application = new Application("Windows");
            var dialog = application.initialize();
            dialog.RenderWindow();

            var webApplication = new Application("Web");
            var webDialog = webApplication.initialize();
            webDialog.RenderWindow();
        }
    }
}
