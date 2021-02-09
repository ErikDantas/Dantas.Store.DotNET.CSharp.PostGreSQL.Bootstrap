using Dantas.Store.Domain.Entities;

namespace Dantas.Store.UI.ViewModels.Products.AddEdit.Maps
{
    public static class Extension
    {
        public static ProductAddEditVM toProductAddEditVM (this Product product)
        {
            return new ProductAddEditVM()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                RegisterDate = product.RegisterDate,
                ProductTypeId = product.ProductTypeId
            };  
        }

        public static Product toProduct(this ProductAddEditVM product)
        {
            return new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                RegisterDate = product.RegisterDate,
                ProductTypeId = product.ProductTypeId
                
            };
        }
    }
}
