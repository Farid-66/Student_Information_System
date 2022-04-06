using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Gender"), Required]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        [ForeignKey("Class"), Required]
        public int ClassId { get; set; }
        public Class Class { get; set; }
        [ForeignKey("Section"), Required]
        public int SectionId { get; set; }
        public Section Section { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [MaxLength(100), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string MobilNumber { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [MaxLength(450)]
        public string StudentImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50), Required]
        public string FathersName { get; set; }
        [MaxLength(150), Required]
        public string FathersOccupation { get; set; }
        [MaxLength(50), Required]
        public string FathersEmail { get; set; }
        [MaxLength(50), Required]
        public string FathersMobil { get; set; }
        [MaxLength(50), Required]
        public string MothersName { get; set; }
        [MaxLength(150), Required]
        public string MothersOccupation { get; set; }
        [MaxLength(50), Required]
        public string MothersEmail { get; set; }
        [MaxLength(50), Required]
        public string MothersMobil { get; set; }
        [MaxLength(2000), Required]
        public string PresentAddress { get; set; }
        [MaxLength(2000), Required]
        public string PermanentAddress { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
