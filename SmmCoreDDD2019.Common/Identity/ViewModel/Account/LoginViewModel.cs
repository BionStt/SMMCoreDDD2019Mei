using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Common.Identity.ViewModel.Account
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
