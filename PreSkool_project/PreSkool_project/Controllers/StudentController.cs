using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Data;
using PreSkool_project.Models;
using PreSkool_project.ViewModels;

namespace PreSkool_project.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public StudentController(AppDbContext context,
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Students
                .Include(s => s.Class)
                .Include(s => s.CustomUser)
                .Include(s => s.Gender)
                .Include(s => s.Section)
                .ThenInclude(d=>d.Department);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.CustomUser)
                .Include(s => s.Section)
                .ThenInclude(d => d.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name");
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name");
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name");
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Name");
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VmStudent student)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = new CustomUser
                {
                    Name=student.Name,
                    Surname=student.Surname,
                    Email = student.Email,
                    UserName = student.Email,
                    CreatedDate = DateTime.Now
                };

                student.CustomUserId = user.Id;

                await _userManager.CreateAsync(user, student.Password);
                string newRoleName = _context.Roles.Find(student.RoleId).Name;
                await _userManager.AddToRoleAsync(user, newRoleName);


                string fileName = Guid.NewGuid() + "-" + student.ImageFile.FileName;
                string filePath = Path.Combine("wwwroot", "Uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    student.ImageFile.CopyTo(stream);
                }
                 
                student.StudentImage=fileName;
                student.CreatedDate = DateTime.Now;

                
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", student.ClassId);
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", student.GenderId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name",student.RoleId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Name", student.SectionId);
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", student.ClassId);
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", student.GenderId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Name", student.SectionId);
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (student.ImageFile != null)
                {
                    string oldImagePath = Path.Combine("wwwroot", "Uploads", student.StudentImage);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }

                    string fileName = Guid.NewGuid() + "-" + student.ImageFile.FileName;
                    string filePath = Path.Combine("wwwroot", "Uploads", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        student.ImageFile.CopyTo(stream);
                    }

                    student.StudentImage = fileName;
                }



                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Classes, "Id", "Name", student.ClassId);
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", student.GenderId);
            ViewData["SectionId"] = new SelectList(_context.Sections, "Id", "Name", student.SectionId);
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .Include(s => s.Section)
                .ThenInclude(d=> d.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            string oldImagePath = Path.Combine("wwwroot", "Uploads", student.StudentImage);
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool StudentExists(int? id)
        {
            return _context.Students.Any(e => e.Id == id);
        }

        public IActionResult DownloadToExcel()
        {
            var model = _context.Students
                .Include(s => s.Class)
                .Include(s => s.CustomUser)
                .Include(s => s.Gender)
                .Include(s => s.Section)
                .ThenInclude(d => d.Department).ToList();

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Student List");

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
            ws.Column("J").Width = 25;
            ws.Column("K").Width = 25;
            ws.Column("L").Width = 25;
            ws.Column("M").Width = 25;
            ws.Column("N").Width = 25;

            ws.Column("N").Style.Alignment.WrapText = true;

            ws.Range("B2:M2").Merge().Value = "Student list";
            ws.Range("B2:M2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B2:M2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B2:M2").Style.Font.FontSize = 14;
            ws.Range("B2:M2").Style.Font.SetBold();

            ws.Range("B3:M3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 120, 120);
            ws.Range("B3:M3").Style.Font.FontColor = XLColor.White;
            ws.Range("B3:M3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B3:M3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B3:M3").Style.Font.FontSize = 14;

            ws.Cell("B3").Value = "#";
            ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("C3").Value = "Name";
            ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("D3").Value = "Surname";
            ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("E3").Value = "Parent Name";
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("F3").Value = "Gender";
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("G3").Value = "DOB";
            ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("H3").Value = "Class";
            ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("I3").Value = "Mobile Number";
            ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("J3").Value = "Date Of Birth";
            ws.Cell("J3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("K3").Value = "Joining Date";
            ws.Cell("K3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("L3").Value = "Address";
            ws.Cell("L3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("M3").Value = "Email";
            ws.Cell("M3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("M3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("N3").Value = "Created Date";
            ws.Cell("N3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("N3").Style.Border.RightBorder = XLBorderStyleValues.Thin;


            for (int i = 0; i < model.Count; i++)
            {
                ws.Range($"B{i + 4}:M{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range($"B{i + 4}:M{i + 4}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

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

                ws.Cell($"D{i + 4}").Value = model[i].Surname;
                ws.Cell($"D{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"E{i + 4}").Value = model[i].FathersName;
                ws.Cell($"E{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"F{i + 4}").Value = model[i].Gender.Name;
                ws.Cell($"F{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"G{i + 4}").Value = model[i].Section.Department.Name;
                ws.Cell($"G{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"H{i + 4}").Value = model[i].Class.Name;
                ws.Cell($"H{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"I{i + 4}").Value = model[i].MobilNumber;
                ws.Cell($"I{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"J{i + 4}").Value = model[i].DateOfBirth.ToString("dd MMMM yyyy");
                ws.Cell($"J{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"K{i + 4}").Value = model[i].JoiningDate.ToString("dd MMMM yyyy");
                ws.Cell($"K{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"L{i + 4}").Value = model[i].PresentAddress;
                ws.Cell($"L{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"M{i + 4}").Value = model[i].CustomUser.Email;
                ws.Cell($"M{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"M{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"M{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"M{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"M{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"N{i + 4}").Value = model[i].CreatedDate.ToString("dd MMMM yyyy hh:mm tt");
                ws.Cell($"N{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"N{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"N{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"N{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"N{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

            }

            using (var stream = new MemoryStream())
            {
                wb.SaveAs(stream);
                var content = stream.ToArray();

                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Student List.xlsx");
            }
        }
    }
}
