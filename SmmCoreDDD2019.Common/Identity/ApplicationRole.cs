using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SmmCoreDDD2019.Common.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole():base()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
        public ApplicationRole(string roleName,string description, DateTime createdDate) :base(roleName)
        {
            this.Description = description;
            this.CreatedDate = CreatedDate;
           // this.IPAddress = IPAddress;
        }


        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Users { get; } = new List<IdentityUserRole<string>>();
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; } = new List<IdentityUserClaim<string>>();
    }
}
