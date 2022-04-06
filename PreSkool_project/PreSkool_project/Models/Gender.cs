using System.ComponentModel.DataAnnotations;

namespace PreSkool_project.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
