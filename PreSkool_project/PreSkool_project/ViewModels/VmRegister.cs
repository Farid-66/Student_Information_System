using Microsoft.AspNetCore.Http;
using PreSkool_project.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.ViewModels
{
    public class VmRegister
    {
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(30), Required]
        public string Password { get; set; }
        public List<CustomUser> CustomUsers { get; set; }
        public Dictionary<string, string> UserRoles { get; set; }
    }
}
