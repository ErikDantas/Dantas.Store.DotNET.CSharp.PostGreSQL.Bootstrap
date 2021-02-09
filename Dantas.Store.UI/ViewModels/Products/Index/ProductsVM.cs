using System;
using System.ComponentModel.DataAnnotations;

namespace Dantas.Store.UI.ViewModels.Products.Index
{
    public class ProductsVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        public DateTime RegisterDate { get; set; }

        public short Quantity { get; set; }

        public decimal Price { get; set; }

        public string ProductType { get; set; }


    }
}
