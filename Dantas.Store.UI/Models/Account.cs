using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dantas.Store.UI.Models
{
    public class Account : Entity
    {
        [Column(TypeName ="varchar")]
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Password { get; set; }
    }
}
