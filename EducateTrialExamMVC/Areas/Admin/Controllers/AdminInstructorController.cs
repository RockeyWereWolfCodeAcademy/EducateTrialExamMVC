using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EducateTrialExamMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminInstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
