using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.ViewModels
{
    public class EditTeachersViewModel:AddTeacherViewModel
    {
        [Key]
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
