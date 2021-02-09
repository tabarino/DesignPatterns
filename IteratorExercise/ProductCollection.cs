using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorExercise
{
    public class ProductCollection : IEnumerable
    {
        private IList<Product> _products = new List<Product>();

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _products)
            {
                yield return item;
            }
        }
        
        public void Add(Product product)
        {
            _products.Add(product);
        }
    }
}
