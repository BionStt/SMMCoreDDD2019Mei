using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Filters
{
    public class ErrorDto
    {
        public string Message { get; set; }
        public IDictionary<string, string[]> Failures { get; set; }
    }
}
