using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace SmmCoreDDD2019.Common.Services
{
    public interface IFunctional
    {
        //Task InitAppData();

        Task CreateDefaultSuperAdmin();

        //Task SendEmailBySendGridAsync(string apiKey,
        //    string fromEmail,
        //    string fromFullName,
        //    string subject,
        //    string message,
        //    string email);

        Task SendEmailByGmailAsync(string fromEmail,
            string fromFullName,
            string subject,
            string messageBody,
            string toEmail,
            string toFullName,
            string smtpUser,
            string smtpPassword,
            string smtpHost,
            int smtpPort,
            bool smtpSSL);

        Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string uploadFolder);

    }
}
