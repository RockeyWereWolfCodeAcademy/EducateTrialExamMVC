using Microsoft.AspNetCore.Mvc;

namespace EducateTrialExamMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminInstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
