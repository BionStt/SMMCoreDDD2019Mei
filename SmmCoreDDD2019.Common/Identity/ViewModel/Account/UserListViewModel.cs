using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Identity.ViewModel.Account
{ 
    public class UserListViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public string StatusMessage { get; set; }
        public bool TwoFactor { get; set; }
        public bool IsEnabled { get; set; }
        public string ProfilePictureUrl { get; set; }

    }
}
