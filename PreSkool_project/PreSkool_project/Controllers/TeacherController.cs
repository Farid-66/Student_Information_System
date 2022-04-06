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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public TeacherController(AppDbContext context,
            UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        // GET: Teacher
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Teachers.Include(t => t.CustomUser).Include(t => t.Gender).Include(t=>t.Subject);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Teacher/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers
                .Include(t => t.CustomUser)
                .Include(t => t.Gender)
                .Include(t => t.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teacher/Create
        public IActionResult Create()
        {
            ViewData["CustomUserId"] = new SelectList(_context.CustomUsers, "Id", "Id");
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name");
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name");
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name");
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VmTeacher teacher)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = new CustomUser
                {
                    Name = teacher.Name,
                    Surname = teacher.Surname,
                    Email = teacher.Email,
                    UserName = teacher.Email,
                    CreatedDate = DateTime.Now
                };

                teacher.CustomUserId = user.Id;

                await _userManager.CreateAsync(user, teacher.Password);
                string newRoleName = _context.Roles.Find(teacher.RoleId).Name;
                await _userManager.AddToRoleAsync(user, newRoleName);


                string fileName = Guid.NewGuid() + "-" + teacher.ImageFile.FileName;
                string filePath = Path.Combine("wwwroot", "Uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    teacher.ImageFile.CopyTo(stream);
                }

                teacher.TeacherImage = fileName;
                teacher.CreatedDate = DateTime.Now;
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomUserId"] = new SelectList(_context.CustomUsers, "Id", "Id", teacher.CustomUserId);
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", teacher.GenderId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Name",teacher.RoleId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name", teacher.SubjectId);
            return View(teacher);
        }

        // GET: Teacher/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            ViewData["CustomUserId"] = new SelectList(_context.CustomUsers, "Id", "Id", teacher.CustomUserId);
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", teacher.GenderId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Name", teacher.SubjectId);
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (teacher.ImageFile != null)
                {
                    string oldImagePath = Path.Combine("wwwroot", "Uploads", teacher.TeacherImage);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }

                    string fileName = Guid.NewGuid() + "-" + teacher.ImageFile.FileName;
                    string filePath = Path.Combine("wwwroot", "Uploads", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        teacher.ImageFile.CopyTo(stream);
                    }

                    teacher.TeacherImage = fileName;
                }

                

                try
                {
                    _context.Update(teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.Id))
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
            ViewData["CustomUserId"] = new SelectList(_context.CustomUsers, "Id", "Id", teacher.CustomUserId);
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", teacher.GenderId);
            return View(teacher);
        }

        // GET: Teacher/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers
                .Include(t => t.CustomUser)
                .Include(t => t.Gender)
                .Include(t => t.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teacher == null)
            {
                return NotFound();
            }

            string oldImagePath = Path.Combine("wwwroot", "Uploads", teacher.TeacherImage);
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _context.Teachers.Any(e => e.Id == id);
        }

        public IActionResult DownloadToExcel()
        {
            var model = _context.Teachers
                .Include(t => t.CustomUser)
                .Include(t => t.Gender)
                .Include(t => t.Subject).ToList();

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Teacher List");

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

            ws.Column("K").Style.Alignment.WrapText = true;

            ws.Range("B2:L2").Merge().Value = "Teacher list";
            ws.Range("B2:L2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B2:L2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B2:L2").Style.Font.FontSize = 14;
            ws.Range("B2:L2").Style.Font.SetBold();

            ws.Range("B3:L3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 120, 120);
            ws.Range("B3:L3").Style.Font.FontColor = XLColor.White;
            ws.Range("B3:L3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B3:L3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B3:L3").Style.Font.FontSize = 14;

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

            ws.Cell("E3").Value = "Gender";
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("F3").Value = "Subject";
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("G3").Value = "Mobile Number";
            ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("H3").Value = "Date Of Birth";
            ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("I3").Value = "Joining Date";
            ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("J3").Value = "Address";
            ws.Cell("J3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("K3").Value = "Email";
            ws.Cell("K3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
        
            ws.Cell("L3").Value = "Created Date";
            ws.Cell("L3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("L3").Style.Border.RightBorder = XLBorderStyleValues.Thin;


            for (int i = 0; i < model.Count; i++)
            {
                ws.Range($"B{i + 4}:L{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range($"B{i + 4}:L{i + 4}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

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

                ws.Cell($"E{i + 4}").Value = model[i].Gender.Name;
                ws.Cell($"E{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"F{i + 4}").Value = model[i].Subject.Name;
                ws.Cell($"F{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"G{i + 4}").Value = model[i].MobilNumber;
                ws.Cell($"G{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"G{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"H{i + 4}").Value = model[i].DateOfBirth.ToString("dd MMMM yyyy");
                ws.Cell($"H{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"H{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"I{i + 4}").Value = model[i].JoiningDate.ToString("dd MMMM yyyy");
                ws.Cell($"I{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"I{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"J{i + 4}").Value = model[i].Address;
                ws.Cell($"J{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"J{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"K{i + 4}").Value = model[i].CustomUser.Email;
                ws.Cell($"K{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"K{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"L{i + 4}").Value = model[i].CreatedDate.ToString("dd MMMM yyyy hh:mm tt");
                ws.Cell($"L{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"L{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

            }

            using (var stream = new MemoryStream())
            {
                wb.SaveAs(stream);
                var content = stream.ToArray();

                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Teacher List.xlsx");
            }
        }
    }
}
