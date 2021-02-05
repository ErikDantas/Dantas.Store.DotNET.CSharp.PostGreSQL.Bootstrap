using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dantas.Store.UI.Models
{
    public class ProductType:Entity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public String Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
