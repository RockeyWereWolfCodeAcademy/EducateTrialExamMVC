using System.ComponentModel.DataAnnotations;

namespace EducateTrialExamMVC.Areas.ViewModels.AdminInstructorVMs
{
    public class AdminInstructorCreateVM
    {
        [Required, MaxLength(32)]
        public string Name { get; set; }
        [Required, MaxLength(32)]
        public string Surname { get; set; }
        [Required, MaxLength(32)]
        public string Profession { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}
