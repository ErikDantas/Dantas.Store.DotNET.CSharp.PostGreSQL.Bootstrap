using Dantas.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Dantas.Store.Data.EF.Maps
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            //Table
            ToTable(nameof(Account));

            //PK
            HasKey(i => i.Id);

            //Columns
            Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(n => n.Name).HasColumnType("varchar")
                .HasMaxLength(100).IsRequired();
            
            Property(n => n.Email).HasColumnType("varchar")
               .HasMaxLength(100).IsRequired()
               .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_db_Account.Email") { IsUnique=true}))
               ;
            
            Property(n => n.Password).HasColumnType("varchar")
               .HasMaxLength(88).IsRequired();


            Property(d => d.RegisterDate);


            //RS
        }
    }
}
