using System.Collections.Generic;
using System.Linq;
using Dantas.Store.Domain.Entities;

namespace Dantas.Store.UI.ViewModels.Products.Index.Maps
{
    public static class Extension
    {
        public static IEnumerable<ProductsVM> toProductsVM (this IEnumerable<Product> product)
        {
            return product.Select(x => new ProductsVM()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                RegisterDate = x.RegisterDate,
                ProductType = x.ProductType.Name
            }) ;

        }
    }
}
