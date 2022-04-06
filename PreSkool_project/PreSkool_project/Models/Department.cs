using System;
using System.ComponentModel.DataAnnotations;

namespace PreSkool_project.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [MaxLength(150),Required]
        public string HOD { get; set; }
        [Required]
        public DateTime DepartmentStartDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
