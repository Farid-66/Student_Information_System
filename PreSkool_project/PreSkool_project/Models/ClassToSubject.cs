using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class ClassToSubject
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100),Required]
        public string Name { get; set; }
        [ForeignKey("Class"),Required]
        public int ClassId { get; set; }
        public Class Class { get; set; }
        [ForeignKey("Subject"),Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
