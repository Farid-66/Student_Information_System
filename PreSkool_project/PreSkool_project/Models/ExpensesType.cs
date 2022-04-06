using System.ComponentModel.DataAnnotations;

namespace PreSkool_project.Models
{
    public class ExpensesType
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
    }
}
