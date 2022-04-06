using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [ForeignKey("Department"), Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; } 
    }
}
