using System;

namespace MementoExercise
{
    public class Demo
    {
        public static void Show()
        {
            var document = new Document();
            var history = new History();

            document.Content = "Test";
            history.Push(document.CreateMemento());

            document.FontName = "Arial";
            history.Push(document.CreateMemento());

            document.FontSize = 12;

            Console.WriteLine(document.ToString());

            document.Restore(history.Pop());
            Console.WriteLine(document.ToString());

            document.Restore(history.Pop());
            Console.WriteLine(document.ToString());
        }
    }
}
