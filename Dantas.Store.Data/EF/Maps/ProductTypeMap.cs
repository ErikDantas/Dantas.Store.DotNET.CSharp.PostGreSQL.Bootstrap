using Dantas.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dantas.Store.Data.EF.Maps
{
    public class ProductTypeMap : EntityTypeConfiguration<ProductType>
    {
        public ProductTypeMap()
        {

            //Table
            ToTable(nameof(ProductType));

            //PK
            HasKey(pk => pk.Id);


            //Columns
            Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(n => n.Name).HasColumnType("varchar")
                .HasMaxLength(100).IsRequired();

            Property(d => d.RegisterDate);





            //RS



        }
    }
}
