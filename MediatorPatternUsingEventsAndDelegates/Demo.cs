using System;

namespace MediatorPatternUsingEventsAndDelegates
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
