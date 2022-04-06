using PreSkool_project.Models;
using System.Collections.Generic;

namespace PreSkool_project.ViewModels
{
    public class VmUser
    {
        public List<CustomUser> CustomUsers { get; set; }
        public Dictionary<string, string> UserRoles { get; set; }
    }
}
