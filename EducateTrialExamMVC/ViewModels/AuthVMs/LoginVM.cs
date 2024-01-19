using System.ComponentModel.DataAnnotations;

namespace EducateTrialExamMVC.ViewModels.AuthVMs
{
    public class LoginVM
    {
        [Required]
        public string UsernameOrEmail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
