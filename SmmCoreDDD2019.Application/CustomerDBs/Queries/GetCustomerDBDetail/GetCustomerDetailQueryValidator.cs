using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBDetail
{
    public class GetCustomerDetailQueryValidator : AbstractValidator<GetCustomerDetailQuery>
    {
        public GetCustomerDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
