using System;

namespace ProxyExercise
{
    public class Demo
    {
        public static void Show()
        {
            var dbContext = new DbContext();
            var product = dbContext.GetProduct(1);
            
            product.Name = "Updated Name";
            dbContext.SaveChanges();

            product.Name = "Another name";
            dbContext.SaveChanges();
        }
    }
}
