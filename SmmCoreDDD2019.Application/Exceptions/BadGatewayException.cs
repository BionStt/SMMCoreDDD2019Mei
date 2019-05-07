using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.Exceptions
{
    public class BadGatewayException : CustomException
    {
        public BadGatewayException(string message): base(HttpStatusCode.BadGateway, message)
        {
        }

        public BadGatewayException()
          : base(HttpStatusCode.BadGateway)
        {
        }
    }
}
