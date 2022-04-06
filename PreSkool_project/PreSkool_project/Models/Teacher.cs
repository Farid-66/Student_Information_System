using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [ForeignKey("Gender"), Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [MaxLength(150), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string MobilNumber { get; set; }
        [ForeignKey("Subject"), Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        [MaxLength(250), Required]
        public string Qualification { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [MaxLength(15), Required]
        public string Experience { get; set; }
        [MaxLength(450)]
        public string TeacherImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(250),Required]
        public string Address { get; set; }
        [MaxLength(50), Required]
        public string City { get; set; }
        [MaxLength(50), Required]
        public string State { get; set; }
        [MaxLength(50), Required]
        public string ZipCode { get; set; }
        [MaxLength(50), Required]
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
