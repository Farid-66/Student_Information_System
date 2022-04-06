using PreSkool_project.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.ViewModels
{
    public class VmTeacher:Teacher
    {
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(30), Required]
        public string Password { get; set; }
        [NotMapped]
        public string RoleId { get; set; }
        public Dictionary<string, string> UserRoles { get; set; }
    }
}
