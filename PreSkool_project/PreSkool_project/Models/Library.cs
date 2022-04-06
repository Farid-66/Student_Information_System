using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Library
    {
        [Key]
        public int BookId { get; set; }
        [MaxLength(50), Required]
        public string BookName { get; set; }
        [MaxLength(50), Required]
        public string Language { get; set; }
        [ForeignKey("Department"), Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
