using Dantas.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Dantas.Store.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<DantasStoreContext>

    {
        protected override void Seed(DantasStoreContext context)
        {
            
            var products = new List<Product>() {new Product()
            {
                Id = 1,
                Name = "Picanha",
                Price = 68.6M,
                Quantity = 8,
                Type = "Food",
                RegisterDate = DateTime.Now
            },new Product()
             {
                Id = 2,
                Name = "Pasta de Dente",
                Price = 8.99M,
                Quantity = 100,
                Type = "Hygiene",
                RegisterDate = DateTime.Now
            },new Product()
             {
                Id = 3,
                Name = "Agua Sanitaria",
                Price = 2.23M,
                Quantity = 98,
                Type = "Cleaning",
                RegisterDate = DateTime.Now
            },new Product()
             {
                Id = 4,
                Name = "Refrigerante",
                Price = 8.55M,
                Quantity = 28,
                Type = "Drinks",
                RegisterDate = DateTime.Now
            } };
            context.produtos.AddRange(products);
            context.SaveChanges();
        }
    }
}