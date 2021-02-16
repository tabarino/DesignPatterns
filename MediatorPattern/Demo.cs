using System;

namespace MediatorPattern
{
    public class Demo
    {
        public static void Show()
        {
            var dialog = new ArticlesDialogBox();
            dialog.SimulateUserInteraction();
        }
    }
}
