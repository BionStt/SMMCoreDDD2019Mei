using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SumberMas2015.Blazor.Server.Models;

namespace SumberMas2015.Blazor.Server.Filters
{
    public class ValidateModelStateFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                    .Where(e => e.Value.Errors.Count > 0)
                    .Select(e => $"{e.Key}: {string.Join(", ", e.Value.Errors.Select(e => e.ErrorMessage))}")
                    .ToList();

                var response = ApiResponse<object>.ErrorResult("Validation failed", errors);
                response.RequestId = context.HttpContext.TraceIdentifier;

                context.Result = new BadRequestObjectResult(response);
            }
        }
    }
}
