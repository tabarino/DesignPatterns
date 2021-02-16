using System;

namespace MediatorPatternUsingObservers
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
