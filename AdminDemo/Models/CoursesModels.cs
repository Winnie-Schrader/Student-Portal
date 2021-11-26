using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Models
{
    public class CoursesModels
    {
        [Key]
        public int CourseID { get; set; }

        [Display(Name ="Department")]
        [Required]
        public Department Dept { get; set; }
     
        [Required]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Course Link")]
        public string CourseLink { get; set; }

    }
}
