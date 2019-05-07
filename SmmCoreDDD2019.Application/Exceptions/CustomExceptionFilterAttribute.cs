using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.Exceptions
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        //public override void OnException(ExceptionContext context)
        //{
        //    var status = HttpStatusCode.InternalServerError;
        //    object message = nameof(HttpStatusCode.InternalServerError);

        //    if (context.Exception is ValidationException validationException)
        //    {
        //        status = HttpStatusCode.BadRequest;
        //        message = RequestValidationHelper.GetValidationFailures(validationException.Errors);
        //    }
        //    else if (context.Exception is CustomException customException)
        //    {
        //        status = customException.Status;
        //        message = customException.Message;
        //    }
        //    else
        //    {
        //        ILogger.LogCritical(context.Exception, "Unexpected Web Layer Exception:");
        //    }

        //    context.HttpContext.Response.ContentType = "application/json";
        //    context.HttpContext.Response.StatusCode = (int)status;
        //    context.Result = new JsonResult(new { status, message });
        //}
    }
}
