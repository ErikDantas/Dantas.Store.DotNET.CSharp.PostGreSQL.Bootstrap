using System;
using System.ComponentModel.DataAnnotations;

namespace Dantas.Store.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "The {0} is required.")]
        [StringLength(70, ErrorMessage = "The maximum length is {1}")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "Invalid email.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "The {0} is required.")]
        [StringLength(40, ErrorMessage = "The maximum length is {1}")]
        public string Password { get; set; }

        public Boolean RememberLogin { get; set; }

        public string ReturnURL { get; set; }
    }
}
