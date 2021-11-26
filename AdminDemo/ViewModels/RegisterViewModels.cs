using AdminDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.ViewModels
{
    public class RegisterViewModels
    {
              
        //EMAIL ADDRESS
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter Your Email Address.")]
        [EmailAddress(ErrorMessage ="Enter a valid Email Address.")]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }


        //PASSWORD
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Your Password.")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be atleast 8 characters")]

        public string Password { get; set; }

        //CONFIRM PASSWORD
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Your Password")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be atleast 8 characters")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string YourName { get; set; }

        [Required]
        [Display(Name = "StudentID")]
        public string StudentID { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Genders UserGender { get; set; }

        [Display(Name = "Department")]
        [Required]
        public Department Department { get; set; }




    }
}
