using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PreSkool_project.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }
        public List<ClassToSubject> ClassToSubjects { get; set; }
    }
}
