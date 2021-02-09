using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dantas.Store.UI.ViewModels.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = "The {0} is required.")]
        [StringLength(70, ErrorMessage = "The maximum length is {1}")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "Invalid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The {0} is required.")]
        [StringLength(40, ErrorMessage = "The maximum length is {1}")]
        public string Password { get; set; }

        public Boolean RememberLogin { get; set; }

        public string ReturnURL { get; set; }
    }
}
