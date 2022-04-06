using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;
using PreSkool_project.ViewModels;
using System.Linq;

namespace PreSkool_project.Controllers
{
    public class TeacherDashboardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public TeacherDashboardController(AppDbContext context,
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {

            VmTeacherDashboard teacher = new VmTeacherDashboard
            {
                Teachers = _context.Teachers
                .Include(t => t.CustomUser)
                .Include(t => t.Subject)
                .ThenInclude(cs=>cs.ClassToSubjects)
                .ThenInclude(c=>c.Class)
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Salaries = _context.Salaries
                .Include(t => t.CustomUser)
                .FirstOrDefault(s => s.CustomUserId == _userManager.GetUserId(User)),

                ClassToSubjects = _context.ClassToSubjects
                .Include(c => c.Class)
                .Include(s => s.Subject)
                .ToList()
            };

            return View(teacher);
        }

        public IActionResult Profile()
        {

            VmTeacherDashboard teacher = new VmTeacherDashboard
            {
                Teachers = _context.Teachers
                .Include(t => t.CustomUser)
                .Include(t => t.Subject)
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),
            };

            return View(teacher);
        }

        public IActionResult Events()
        {
            VmTeacherDashboard events = new VmTeacherDashboard
            {
                Teachers = _context.Teachers
                .Include(t => t.CustomUser)
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Holidays= _context.Holidays.Include(h => h.HolidayType).ToList()
            };

            return View(events);
        }

        public IActionResult Library()
        {

            VmTeacherDashboard books = new VmTeacherDashboard
            {
                Teachers = _context.Teachers
                .Include(t => t.CustomUser)
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Books = _context.Libraries.Include(d => d.Department).ToList()
            };

            return View(books);
        }

        public IActionResult Exams()
        {
            VmTeacherDashboard exams = new()
            {
                Teachers= _context.Teachers
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Exams = _context.Exams
                .Include(cs => cs.ClassToSubject)
                .ThenInclude(c => c.Class)
                .Include(cs => cs.ClassToSubject)
                .ThenInclude(s => s.Subject)
                .ToList()
            };

            return View(exams);
        }
    }
}
