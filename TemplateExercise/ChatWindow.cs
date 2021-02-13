using System;

namespace TemplateExercise
{
    public class ChatWindow : Window
    {
        protected override void AfterCloseHook()
        {
            base.AfterCloseHook();
            Console.WriteLine("Disconnecting from the server");
        }
    }
}
