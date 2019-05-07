using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(HttpStatusCode status, string message)
      : base(message)
        {
            Status = status;
        }

        public CustomException(HttpStatusCode status)
          : base(nameof(status))
        {
            Status = status;
        }

        public CustomException(string message)
          : base(message)
        {
            Status = HttpStatusCode.InternalServerError;
        }

        public CustomException()
          : base(nameof(HttpStatusCode.InternalServerError))
        {
            Status = HttpStatusCode.InternalServerError;
        }

        public HttpStatusCode Status { get; }
    }
}
