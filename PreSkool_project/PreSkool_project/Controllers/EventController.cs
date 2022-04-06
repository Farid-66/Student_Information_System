using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.ViewModels;
using System.Linq;

namespace PreSkool_project.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmEvents model = new VmEvents();
            model.Holidays = _context.Holidays
                .Include(h=>h.HolidayType)
                .ToList();
            model.Exams = _context.Exams
                .Include(e => e.ClassToSubject)
                .ThenInclude(c => c.Class)
                .Include(cs => cs.ClassToSubject)
                .ThenInclude(s => s.Subject)
                .ToList();
            return View(model);
        }
    }
}
