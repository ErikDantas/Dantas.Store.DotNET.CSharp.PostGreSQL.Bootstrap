using Dantas.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dantas.Store.UI.Data
{
    public class DantasStoreContext : DbContext
    {
        public DantasStoreContext():base("StoreDbSQL")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<Account> accounts { get; set; }
    }
}
