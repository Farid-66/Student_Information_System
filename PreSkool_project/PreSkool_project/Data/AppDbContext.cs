using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PreSkool_project.Models;

namespace PreSkool_project.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
                
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassToSubject> ClassToSubjects { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Annual> Annuals { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<HolidayType> HolidayTypes { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<ExpensesType> ExpensesTypes { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Library> Libraries { get; set; }


    }
}
