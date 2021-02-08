using Dantas.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dantas.Store.Data.EF.Maps
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            //Table
            ToTable(nameof(Product));

            //PK
            HasKey(p => p.Id);

            //Column
            Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(n => n.Name).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            Property(p => p.Price).HasColumnType("money");

            Property(q => q.Quantity);

            Property(pi => pi.ProductTypeId);

            Property(d => d.RegisterDate);


            //RS
            HasRequired(x => x.ProductType)
                .WithMany(t => t.Products)
                .HasForeignKey(k => k.ProductTypeId);
            
        }
    }
}
