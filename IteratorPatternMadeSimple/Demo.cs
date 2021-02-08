using System;

namespace IteratorPatternMadeSimple
{
    public class Demo
    {
        public static void Show()
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            foreach (var url in history)
            {
                Console.WriteLine(url);
            }
        }
    }
}
