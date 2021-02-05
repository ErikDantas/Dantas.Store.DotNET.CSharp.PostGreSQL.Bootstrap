using Dantas.Store.UI.Models;
using System;
using Dantas.Store.UI.Infra.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace Dantas.Store.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<DantasStoreContext>

    {
        protected override void Seed(DantasStoreContext context)
        {

            var electronics = new ProductType() { Name = "Electronics" };
            var foods = new ProductType() { Name = "Foods" };
            var others = new ProductType() { Name = "Others" };
            var cloths = new ProductType() { Name = "Cloths" };
            var drinks = new ProductType() { Name = "Drinks" };

            var products = new List<Product>() {new Product()
            {
                Id = 1,
                Name = "Picanha",
                Price = 68.6M,
                Quantity = 8,
                ProductType = foods
            },new Product()
             {
                Id = 2,
                Name = "Pasta de Dente",
                Price = 8.99M,
                Quantity = 100,
                ProductType = others
            },new Product()
             {
                Id = 3,
                Name = "Agua Sanitaria",
                Price = 2.23M,
                Quantity = 98,
                ProductType = others
            },new Product()
             {
                Id = 4,
                Name = "Refrigerante",
                Price = 8.55M,
                Quantity = 28,
                ProductType = drinks
            },new Product()
             {
                Id = 5,
                Name = "T-Shirts",
                Price = 19.19M,
                Quantity = 50,
                ProductType = cloths
            } };
            context.products.AddRange(products);

            context.accounts.Add(new Account() { Name = "Jose Erik Ramos Dantas", Email = "jose.erikdantas@outlook.com", Password = "joseerik".Encrypt() });

            context.SaveChanges();
        }
    }
}