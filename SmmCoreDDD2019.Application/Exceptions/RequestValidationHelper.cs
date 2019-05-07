using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.Exceptions
{
    public class RequestValidationHelper
    {
        //public static Dictionary<string, string[]> GetValidationFailures(IEnumerable<ValidationFailure> failures)
        //{
        //    var validationFailures = failures.ToList();
        //    var propertyNames = validationFailures
        //      .Select(e => e.PropertyName)
        //      .Distinct();

        //    var message = new Dictionary<string, string[]>();

        //    foreach (var propertyName in propertyNames)
        //    {
        //        var propertyFailures = validationFailures
        //          .Where(e => e.PropertyName == propertyName)
        //          .Select(e => e.ErrorMessage)
        //          .ToArray();

        //        message.Add(propertyName, propertyFailures);
        //    }

        //    return message;
        //}

    }
}
