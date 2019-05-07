using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace SmmCoreDDD2019.Common.Filters
{
    public class NotFoundException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;

        public NotFoundException(string name, object key)
            : this($"Entity \"{name}\" ({key}) was not found.")
        {
        }

        public NotFoundException(string message)
        {
            ErrorDetails = new ErrorDto
            {
                Message = message,
                Failures = new Dictionary<string, string[]>()
            };
        }
    }
}
