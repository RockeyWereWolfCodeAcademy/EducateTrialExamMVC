using EducateTrialExamMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EducateTrialExamMVC.Contexts
{
    public class EdukateDbContext : IdentityDbContext
    {
        public EdukateDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
