using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dantas.Store.UI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime RegisterDate { get; set; }
        public short Quantity { get; set; }
        public String Type { get; set; }
        public decimal Price { get; set; }
    }
}
