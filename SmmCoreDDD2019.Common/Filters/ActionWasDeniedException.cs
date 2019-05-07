using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace SmmCoreDDD2019.Common.Filters
{
    public class ActionWasDeniedException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.Forbidden;

        public ActionWasDeniedException(string message = null)
        {
            ErrorDetails = new ErrorDto
            {
                Message = $"Action was denied! {message}",
                Failures = new Dictionary<string, string[]>()
            };
        }
    }
}
