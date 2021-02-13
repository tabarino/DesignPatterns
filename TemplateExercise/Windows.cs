using System;

namespace TemplateExercise
{
    public class Window
    {
        public void Close()
        {
            BeforeCloseHook();

            Console.WriteLine("Removing the window from the screen");

            AfterCloseHook();
        }

        protected virtual void BeforeCloseHook()
        {
            Console.WriteLine("Do something on base class before closing the screen");
        }

        protected virtual void AfterCloseHook()
        {
            Console.WriteLine("Do something on base class after closing the screen");
        }
    }
}
