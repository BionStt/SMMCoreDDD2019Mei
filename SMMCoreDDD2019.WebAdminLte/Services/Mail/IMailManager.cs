using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.WebAdminLte.Services.Mail
{
    public interface IMailManager
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
