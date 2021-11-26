using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Models
{
    public class ApplicationUser:IdentityUser
    {

        public string YourName { get; set; }
        public string StudentID { get; set; }
        public Genders UserGender { get; set; }
        public Department Department { get; set; }
    }
}
