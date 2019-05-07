using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation.Results;
using System.Net;

namespace SmmCoreDDD2019.Common.Filters
{
    public class ValidationException : ExceptionBase
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public ValidationException()
        {
            ErrorDetails = new ErrorDto
            {
                Message = "One or more validation failures have occurred.",
                Failures = new Dictionary<string, string[]>()
            };
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            var propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (var propertyName in propertyNames)
            {
                var propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();
                ErrorDetails.Failures.Add(propertyName, propertyFailures);
            }
        }

        public ValidationException(string message, IEnumerable<ValidationFailure> failures)
            : this(failures)
        {
            ErrorDetails.Message = message;
        }
    }
}
