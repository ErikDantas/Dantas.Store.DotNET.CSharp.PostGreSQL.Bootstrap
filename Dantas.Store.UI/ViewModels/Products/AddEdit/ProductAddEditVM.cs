using System;
using System.ComponentModel.DataAnnotations;

namespace Dantas.Store.UI.ViewModels.Products.AddEdit
{
    public class ProductAddEditVM
    {
        public ProductAddEditVM()
        {
            RegisterDate = DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        public DateTime RegisterDate { get; set; }

        public short Quantity { get; set; }

        public decimal Price { get; set; }

        [Display(Name= "Product Type")]
        public int ProductTypeId { get; set; }
    }
}
