using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace SmmCoreDDD2019.Common.Filters
{
    public class UploadedFileIsEmptyException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NoContent;

        public UploadedFileIsEmptyException()
        {
            ErrorDetails = new ErrorDto
            {
                Message = "Could not find sent files.",
                Failures = new Dictionary<string, string[]>()
            };
        }
    }
}
