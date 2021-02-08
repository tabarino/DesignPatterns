using System;

namespace IteratorPattern
{
    public class Demo
    {
        public static void Show()
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            var iterator = history.createIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }
        }
    }
}
