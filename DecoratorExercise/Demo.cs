using System;

namespace DecoratorExercise
{
    public class Demo
    {
        public static void Show()
        {
            var editor = new Editor();
            editor.OpenProject("...");
        }
    }
}
