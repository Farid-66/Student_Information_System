using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreSkool_project.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(50),Required]
        public string Name { get; set; }
        [MaxLength(50),Required]
        public string Surname { get; set; }
        [NotMapped]
        public string RoleId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
