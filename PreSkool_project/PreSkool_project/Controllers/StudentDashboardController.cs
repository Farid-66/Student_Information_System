using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;
using PreSkool_project.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace PreSkool_project.Controllers
{
    public class StudentDashboardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<CustomUser> _userManager;

        public StudentDashboardController(AppDbContext context,
            UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            VmStudentDashboard student = new()
            {
                Student = _context.Students
                .Include(s => s.Class)
                .ThenInclude(cs => cs.ClassToSubjects)
                .ThenInclude(s => s.Subject)
                .Include(s => s.CustomUser)
                .Include(s => s.Section)
                .ThenInclude(s => s.Department)
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Annual = _context.Annuals
                .Include(s => s.CustomUser)
                .FirstOrDefault(a => a.CustomUserId == _userManager.GetUserId(User)),

                ClassToSubjects = _context.ClassToSubjects
                .Include(c => c.Class)
                .Include(s => s.Subject)
                .ToList()
            };

            return View(student);
        }

        public IActionResult Profile()
        {
            VmStudentDashboard profile = new()
            {
                Student = _context.Students
                .Include(s => s.Section)
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User))
            };

            return View(profile);
        }

        public IActionResult Events()
        {

            VmStudentDashboard events = new()
            {
                Student = _context.Students
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Holidays = _context.Holidays.Include(h => h.HolidayType).ToList()
            };

            return View(events);
        }

        public IActionResult Library()
        {
            VmStudentDashboard books = new()
            {
                Student = _context.Students
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Books = _context.Libraries.Include(d => d.Department).ToList()
            };

            return View(books);
        }

        public IActionResult Exams()
        {
            VmStudentDashboard exams = new()
            {
                Student = _context.Students
                .FirstOrDefault(m => m.CustomUserId == _userManager.GetUserId(User)),

                Exams =_context.Exams
                .Include(cs=>cs.ClassToSubject)
                .ThenInclude(c=>c.Class)
                .Include(cs=>cs.ClassToSubject)
                .ThenInclude(s=>s.Subject)
                .ToList()
            };

            return View(exams);
        }
    }
}
