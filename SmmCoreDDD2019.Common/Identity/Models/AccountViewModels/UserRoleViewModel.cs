using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Identity.Models.AccountViewModels
{
    public class UserRoleViewModel
    {
        public int CounterId { get; set; }
        public string ApplicationUserId { get; set; }
        public string RoleName { get; set; }
        public bool IsHaveAccess { get; set; }
    }
}
