using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.ViewModels
{
    public class LoginViewModel
    {
 
        //EMAIL ADDRESS
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter Your Email Address.")]
        [EmailAddress(ErrorMessage = "Enter a valid Email Address.")]
        public string Email { get; set; }


        //PASSWORD
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Your Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
