using PreSkool_project.Models;
using System.Collections.Generic;

namespace PreSkool_project.ViewModels
{
    public class VmAdmin
    {
        public CustomUser CustomUsers { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Annual> Annuals { get; set; }
        public List<Expenses> Expenses { get; set; }
        public List<Salary> Salaries { get; set; }
        public List<Department> Departments { get; set; }
    }
}
