using EducateTrialExamMVC.Areas.ViewModels.AdminInstructorVMs;
using EducateTrialExamMVC.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducateTrialExamMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminInstructorController : Controller
    {
        readonly EdukateDbContext _context;

        public AdminInstructorController(EdukateDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            var data = await _context.Instructors.Select(inst => new AdminInstructorListVM
            {
                Id = inst.Id,
                Name = inst.Name,
                Surname = inst.Surname,
                ImgUrl = inst.ImgUrl,
                Profession = inst.Profession,
            }).ToListAsync();
            return View(data);
        }

    }
}
