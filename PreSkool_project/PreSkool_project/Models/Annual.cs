using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Annual
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Title { get; set; }
        [ForeignKey("CustomUser"),Required]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [MaxLength(50),Required]
        public string Fees { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
