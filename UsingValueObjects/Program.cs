using System;
using System.Collections.Generic;
using UsingValueObjects.Data;
using UsingValueObjects.Data.Models;

namespace UsingValueObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var products = new List<Product>
                {
                    new Product { Id = Guid.NewGuid(), Name = "A 51", Manufacture = "Samsung", Price = new Money(Currency.Toman, 75000000) },
                    new Product { Id = Guid.NewGuid(), Name = "A 71", Manufacture = "Samsung", Price = new Money(Currency.Toman, 9000000) }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
