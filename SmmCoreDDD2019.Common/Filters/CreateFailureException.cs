using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace SmmCoreDDD2019.Common.Filters
{
    public class CreateFailureException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public CreateFailureException(string name)
        {
            ErrorDetails = new ErrorDto
            {
                Message = $"Creation of entity \"{name}\" failed.",
                Failures = new Dictionary<string, string[]>()
            };
        }

        public CreateFailureException(string name, IDictionary<string, string[]> failures) : this(name)
        {
            ErrorDetails.Failures = failures;
        }
    }
}
