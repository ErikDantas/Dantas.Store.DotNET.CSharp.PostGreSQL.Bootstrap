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
        public DantasStoreContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dantasstore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Product> produtos { get; set; }
    }
}
