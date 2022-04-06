using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [ForeignKey("ClassToSubject"), Required]
        public int ClassToSubjectId { get; set; }
        public ClassToSubject ClassToSubject { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public DateTime EventDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
