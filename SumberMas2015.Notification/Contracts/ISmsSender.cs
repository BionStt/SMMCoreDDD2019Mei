using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Notification.Contracts
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
