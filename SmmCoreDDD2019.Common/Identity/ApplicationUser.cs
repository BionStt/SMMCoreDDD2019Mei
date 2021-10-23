using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SmmCoreDDD2019.Common.Identity
{
    public class ApplicationUser :IdentityUser
    {
        public ApplicationUser():base()
        {
        }

        public string Name { get; set; }
        public bool IsEnabled { get;   set; }
        public DateTime LastLoginDate { get; set; }
        public string LocalIPAddress { get; set; }
        public string LocalPort { get; set; }
        public string RemoteIPAddress { get; set; }
        public string RemotePort { get; set; }

     //   public string profilePictureUrl { get; set; } = "/images/empty_profile.png";
        public string profilePictureUrl { get; set; } = "/upload/blank-person.png";
        public bool isSuperAdmin { get; set; } = false;

        [Display(Name = "Home Roles")]
        public bool HomeRole { get; set; } = false;

        [Display(Name = "Roles")]
        public bool ApplicationUserRole { get; set; } = false;

        public virtual ICollection<IdentityUserRole<string>> Roles { get; } = new List<IdentityUserRole<string>>();
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; } = new List<IdentityUserClaim<string>>();

    }
}
