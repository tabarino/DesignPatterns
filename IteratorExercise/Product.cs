using System;

namespace IteratorExercise
{
    public class Product
    {
        private readonly int _id;
        private readonly string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $"Product - Id: {_id}, Name: {_name}.";
        }
    }
}
