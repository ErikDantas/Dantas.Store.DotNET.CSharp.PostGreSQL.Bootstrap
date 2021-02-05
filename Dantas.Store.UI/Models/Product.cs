using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dantas.Store.UI.Models
{
    
    public class Product:Entity
    {

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public String Name { get; set; }
        
        
        public short Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int ProductTypeId { get; set; }
        [ForeignKey(nameof(ProductTypeId))]
        public virtual ProductType ProductType { get; set; }

        
    }
}
