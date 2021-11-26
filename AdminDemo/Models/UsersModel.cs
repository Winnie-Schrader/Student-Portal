using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Models
{
    public class UsersModel
    {
        [Key]
        public int Id { get; set; }
        //UserName
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Enter your Username.")]
        public string UserName { get; set; }

        //Gender
        [Display(Name = "Gender")]
        [Required]
        public Genders Gender { get; set; }
        //DEPARTMENT
        [Display(Name = "Department")]
        [Required]
        public Department Department { get; set; }

        [Display(Name = "StudentID")]
        [Required(ErrorMessage = "Enter your StudentID(Check your ID Card)")]
        public string StudentID { get; set; }

        //EMAIL ADDRESS
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter Your Email Address.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid Email Address")]
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

    }
}
