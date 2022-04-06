using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;
using PreSkool_project.ViewModels;

namespace PreSkool_project.Controllers
{
    public class ClassToSubjectsController : Controller
    {
        private readonly AppDbContext _context;

        public ClassToSubjectsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ClassToSubjects
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ClassToSubjects.Include(c => c.Class).Include(c => c.Subject);
            return View(await appDbContext.ToListAsync());
        }

        // GET: ClassToSubjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classToSubject = await _context.ClassToSubjects
                .Include(c => c.Class)
                .Include(c => c.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classToSubject == null)
            {
                return NotFound();
            }

            return View(classToSubject);
        }

        // GET: ClassToSubjects/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name");
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name");
            return View();
        }

        // POST: ClassToSubjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClassToSubject classToSubject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classToSubject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", classToSubject.ClassId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name", classToSubject.SubjectId);
            return View(classToSubject);
        }

        // GET: ClassToSubjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classToSubject = await _context.ClassToSubjects.FindAsync(id);
            if (classToSubject == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", classToSubject.ClassId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name", classToSubject.SubjectId);
            return View(classToSubject);
        }

        // POST: ClassToSubjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ClassToSubject classToSubject)
        {
            if (id != classToSubject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classToSubject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassToSubjectExists(classToSubject.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", classToSubject.ClassId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name", classToSubject.SubjectId);
            return View(classToSubject);
        }

        // GET: ClassToSubjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classToSubject = await _context.ClassToSubjects
                .Include(c => c.Class)
                .Include(c => c.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classToSubject == null)
            {
                return NotFound();
            }
            _context.ClassToSubjects.Remove(classToSubject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassToSubjectExists(int id)
        {
            return _context.ClassToSubjects.Any(e => e.Id == id);
        }
    }
}
