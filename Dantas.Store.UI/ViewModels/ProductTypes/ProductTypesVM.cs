using System;
using System.ComponentModel.DataAnnotations;

namespace Dantas.Store.UI.ViewModels.ProductTypes
{
    public class ProductTypesVM
    {
        public ProductTypesVM()
        {
            RegisterDate = DateTime.Now;
        }
        public int Id { get; set; }
        [Required,StringLength(100)]
        public String Name { get; set; }
        public  DateTime RegisterDate { get; set; }

    }
}
