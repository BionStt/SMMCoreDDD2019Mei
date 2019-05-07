using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
namespace SmmCoreDDD2019.Common.Filters
{
    public abstract class ExceptionBase : Exception
    {
        public ErrorDto ErrorDetails { get; protected set; }
        public abstract HttpStatusCode StatusCode { get; }
    }
}
