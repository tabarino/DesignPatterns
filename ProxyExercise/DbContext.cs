using System;
using System.Collections.Generic;

namespace ProxyExercise
{
    public class DbContext
    {
        private IDictionary<int, Product> _updatedObjects = new Dictionary<int,Product>();

        public Product GetProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine($"SELECT * FROM products WHERE product_id = {id}");

            var product = new ProductProxy(id, this);
            product.Name = "Product 1";

            return product;
        }

        public void SaveChanges() {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in _updatedObjects.Values)
            {
                Console.WriteLine($"UPDATE products SET name = '{updatedObject.Name}' WHERE product_id = {updatedObject.Id}");
            }
        }

        public void MarkAsChanged(Product product) {
            _updatedObjects.Add(product.Id, product);
        }
    }
}
