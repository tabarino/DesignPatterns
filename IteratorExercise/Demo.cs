using System;

namespace IteratorExercise
{
    public class Demo
    {
        public static void Show()
        {
            var collection = new ProductCollection();
            collection.Add(new Product(1, "a"));
            collection.Add(new Product(2, "b"));
            collection.Add(new Product(3, "c"));

            foreach (var product in collection)
            {
                Console.WriteLine(product);
            }
        }
    }
}
