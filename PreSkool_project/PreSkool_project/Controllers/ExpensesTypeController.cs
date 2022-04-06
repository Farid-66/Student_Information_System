using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;

namespace PreSkool_project.Controllers
{
    public class ExpensesTypeController : Controller
    {
        private readonly AppDbContext _context;

        public ExpensesTypeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ExpensesType
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExpensesTypes.ToListAsync());
        }

        // GET: ExpensesType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expensesType = await _context.ExpensesTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expensesType == null)
            {
                return NotFound();
            }

            return View(expensesType);
        }

        // GET: ExpensesType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpensesType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ExpensesType expensesType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expensesType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expensesType);
        }

        // GET: ExpensesType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expensesType = await _context.ExpensesTypes.FindAsync(id);
            if (expensesType == null)
            {
                return NotFound();
            }
            return View(expensesType);
        }

        // POST: ExpensesType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ExpensesType expensesType)
        {
            if (id != expensesType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expensesType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpensesTypeExists(expensesType.Id))
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
            return View(expensesType);
        }

        // GET: ExpensesType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expensesType = await _context.ExpensesTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expensesType == null)
            {
                return NotFound();
            }
            _context.ExpensesTypes.Remove(expensesType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpensesTypeExists(int id)
        {
            return _context.ExpensesTypes.Any(e => e.Id == id);
        }
    }
}
