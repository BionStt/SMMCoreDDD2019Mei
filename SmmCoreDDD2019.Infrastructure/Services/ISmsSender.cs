using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Infrastructure.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
