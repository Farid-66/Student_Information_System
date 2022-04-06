using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;

namespace PreSkool_project.Controllers
{
    public class ExamController : Controller
    {
        private readonly AppDbContext _context;

        public ExamController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Exam
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Exams
                .Include(e => e.ClassToSubject)
                .ThenInclude(c => c.Class)
                .Include(e => e.ClassToSubject)
                .ThenInclude(s => s.Subject);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Exam/Create
        public IActionResult Create()
        {
            ViewData["ClassToSubjectId"] = new SelectList(_context.ClassToSubjects, "Id", "Name");
            return View();
        }

        // POST: Exam/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Exam exam)
        {
            if (ModelState.IsValid)
            {
                exam.CreatedDate = DateTime.Now;
                _context.Add(exam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassToSubjectId"] = new SelectList(_context.ClassToSubjects, "Id", "Name", exam.ClassToSubjectId);
            return View(exam);
        }

        // GET: Exam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }
            ViewData["ClassToSubjectId"] = new SelectList(_context.ClassToSubjects, "Id", "Name", exam.ClassToSubjectId);
            return View(exam);
        }

        // POST: Exam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Exam exam)
        {
            if (id != exam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamExists(exam.Id))
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
            ViewData["ClassToSubjectId"] = new SelectList(_context.ClassToSubjects, "Id", "Name", exam.ClassToSubjectId);
            return View(exam);
        }

        // GET: Exam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.ClassToSubject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exam == null)
            {
                return NotFound();
            }
            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool ExamExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }

        public IActionResult DownloadToExcel()
        {
            var model = _context.Exams
                .Include(e => e.ClassToSubject)
                .ThenInclude(c => c.Class)
                .Include(e => e.ClassToSubject)
                .ThenInclude(s => s.Subject).ToList();

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Exam List");

            ws.Row(1).Height = 4;
            ws.Row(2).Height = 30;
            ws.Row(3).Height = 25;

            ws.Column("A").Width = 0.4;
            ws.Column("B").Width = 6;
            ws.Column("C").Width = 25;
            ws.Column("D").Width = 25;
            ws.Column("E").Width = 25;
            ws.Column("F").Width = 25;
            ws.Column("G").Width = 25;
            ws.Column("H").Width = 25;
            ws.Column("I").Width = 25;

            ws.Column("E").Style.Alignment.WrapText = true;

            ws.Range("B2:I2").Merge().Value = "Exam list";
            ws.Range("B2:I2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B2:I2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B2:I2").Style.Font.FontSize = 14;
            ws.Range("B2:I2").Style.Font.SetBold();

            ws.Range("B3:I3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 120, 120);
            ws.Range("B3:I3").Style.Font.FontColor = XLColor.White;
            ws.Range("B3:I3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B3:I3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B3:I3").Style.Font.FontSize = 14;

            ws.Cell("B3").Value = "#";
            ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("C3").Value = "Exam Name";
            ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("D3").Value = "Class";
            ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("E3").Value = "Subject";
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("F3").Value = "Start Time";
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("G3").Value = "End Time";
            ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("H3").Value = "Event Date";
            ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("I3").Value = "Created Date";
            ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;


            for (int i = 0; i < model.Count; i++)
            {
                ws.Range($"B{i + 4}:J{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range($"B{i + 4}:J{i + 4}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                ws.Cell($"B{i + 4}").Value = (i + 1);
                ws.Cell($"B{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"B{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"B{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"B{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell($"C{i + 4}").Value = model[i].Name;
                ws.Cell($"C{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"D{i + 4}").Value = model[i].ClassToSubject.Class.Name;
                ws.Cell($"D{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"E{i + 4}").Value = model[i].ClassToSubject.Subject.Name;
                ws.Cell($"E{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"F{i + 4}").Value = model[i].StartTime;
                ws.Cell($"F{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"G{i + 4}").Value = model[i].EndTime;
                ws.Cell($"G{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"H{i + 4}").Value = model[i].EventDate;
                ws.Cell($"H{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"I{i + 4}").Value = model[i].CreatedDate;
                ws.Cell($"I{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

            }

            using (var stream = new MemoryStream())
            {
                wb.SaveAs(stream);
                var content = stream.ToArray();

                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Exam List.xlsx");
            }
        }
    }
}
