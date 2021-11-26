using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Models
{
    public class TeachersModel
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage ="Enter a valid Name")]
        [Display(Name ="Teacher Name")]
        public string TeacherName { get; set; }

        [Required(ErrorMessage ="Enter a valid Department")]
        [Display(Name = "Teacher Department")]

        public string TeacherDept { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Enter a valid Designation")]
        public string TeacherDesignation { get; set; }

        [Display(Name = "Qualification")]
        [Required(ErrorMessage = "Enter a valid Qualification")]
        public string TeacherQualification { get; set; }

        public string PhotoPath { get; set; }

    }
}
