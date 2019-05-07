using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Services
{
    public class SendGridOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
        public string FromEmail { get; set; }
        public string FromFullName { get; set; }
        public bool IsDefault { get; set; }
    }
}
