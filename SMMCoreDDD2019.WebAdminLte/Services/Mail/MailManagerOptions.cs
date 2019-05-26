using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.WebAdminLte.Services.Mail
{
    public class MailManagerOptions
    {
        public string EmailProvider { get; set; }
        public string SupportTeamEmail { get; set; }
        public string SupportTeamName { get; set; }
    }
}
