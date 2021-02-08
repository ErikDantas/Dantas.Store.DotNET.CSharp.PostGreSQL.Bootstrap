using System;

namespace Dantas.Store.Domain.Entities
{
    public class Product : Entity
    {

        public String Name { get; set; }


        public short Quantity { get; set; }

        public decimal Price { get; set; }

        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }


    }
}
