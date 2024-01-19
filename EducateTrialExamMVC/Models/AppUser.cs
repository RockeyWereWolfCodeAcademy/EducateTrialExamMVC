using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EducateTrialExamMVC.Models
{
    public class AppUser : IdentityUser
    {
        [MaxLength(32)]
        public string Name { get; set; }
        [MaxLength(32)]
        public string Surname { get; set; }

    }
}
