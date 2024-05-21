using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BGHAmbulance.Models
{
    public class UserRole
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public AspNetUser U { get; set; }
        public List<AspNetRole> Roles { get; set; }
    }
}