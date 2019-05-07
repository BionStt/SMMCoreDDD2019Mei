using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using System.Net;

namespace SmmCoreDDD2019.Common.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomExceptionFilterAttribute2: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            HttpStatusCode statusCode;
            ErrorDto errorMessage;

            if (context.Exception is ExceptionBase processedException)
            {
                statusCode = processedException.StatusCode;
                errorMessage = processedException.ErrorDetails;
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
                errorMessage = new ErrorDto
                {
                    Message = context.Exception.Message
                };
            }

            context.Result = new JsonResult(errorMessage);
            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.HttpContext.Response.ContentType = "application/json";
        }
    }
}
