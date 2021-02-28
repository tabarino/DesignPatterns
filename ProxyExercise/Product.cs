using System;

namespace ProxyExercise
{
    public class Product
    {
        private readonly int _id;

        public int Id => _id;

        public string Name { get; set; }

        public Product(int id)
        {
            _id = id;
        }
    }
}
