using Dantas.Store.UI.ViewModels.ProductTypes;
using System.Collections.Generic;
using System.Linq;
using Dantas.Store.Domain.Entities;

namespace Dantas.Store.UI.ViewModels.ProductTypes.Maps
{
    public static class Extension
    {
        public static IEnumerable<ProductTypesVM> toProductTypesVM(this IEnumerable<Dantas.Store.Domain.Entities.ProductType> producttype)
        {
            return producttype.Select(x => new ProductTypesVM()
            {
                Id = x.Id,
                Name = x.Name,
                RegisterDate = x.RegisterDate
            });

        }
        public static ProductTypesVM toProductTypeVM(this Dantas.Store.Domain.Entities.ProductType producttype)
        {
            return new ProductTypesVM()
            {
                Id = producttype.Id,
                Name = producttype.Name,
                RegisterDate = producttype.RegisterDate
            };

        }
        public static ProductType toOneProductType(this ProductTypesVM producttype)
        {
            return new ProductType()
            {
                Id = producttype.Id,
                Name = producttype.Name,
                RegisterDate = producttype.RegisterDate
            };

        }
    }
}
