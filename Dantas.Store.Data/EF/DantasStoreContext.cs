using Dantas.Store.Data.EF.Maps;
using Dantas.Store.Domain.Entities;
using System.Data.Entity;

namespace Dantas.Store.Data.EF
{
    public class DantasStoreContext : DbContext
    {
        public DantasStoreContext() : base("StoreDbSQL")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<Account> accounts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductTypeMap());
            modelBuilder.Configurations.Add(new AccountMap());
        }
    }

    
}
