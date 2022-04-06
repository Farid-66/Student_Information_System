using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;
using PreSkool_project.ViewModels;
using System.Linq;

namespace PreSkool_project.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<CustomUser> _userManager;

        public AdminController(AppDbContext context,
            UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            VmAdmin admin = new VmAdmin();
            admin.CustomUsers = _context.CustomUsers.FirstOrDefault(m => m.Id == _userManager.GetUserId(User));
            admin.Teachers = _context.Teachers.Include(t=>t.Subject).ToList();
            admin.Students = _context.Students.Include(s=>s.Class).Include(s=>s.Section).ThenInclude(d => d.Department).ToList();
            admin.Departments = _context.Departments.ToList();
            admin.Annuals = _context.Annuals.ToList();
            admin.Expenses = _context.Expenses.ToList();
            admin.Salaries = _context.Salaries.ToList();

            return View(admin);
        }
    }
}
