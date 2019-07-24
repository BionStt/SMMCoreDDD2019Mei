using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using SmmCoreDDD2019.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmmCoreDDD2019.Domain.Entities;
using System.Collections;

namespace SmmCoreDDD2019.QueryStack.AccountingDataAccountDB.GetDataAccountByParent2
{
    public class GetDataAccountByParent2QueryHandler: IRequestHandler<GetDataAccountByParent2Query, GetDataAccountByParent2ViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly ILogger _logger;

        public GetDataAccountByParent2QueryHandler(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<ISMMCoreDDD2019DbContext>();
            _logger = serviceProvider.GetService<ILogger<GetDataAccountByParent2QueryHandler>>();
        }

        public async Task<GetDataAccountByParent2ViewModel> Handle(GetDataAccountByParent2Query request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Getting Transactions List");

            try
            {
                var aa = await(from Parent in _context.AccountingDataAccount
                               from Child in _context.AccountingDataAccount
                               where Child.Lft > Parent.Lft && Child.Lft < Parent.Rgt && Parent.KodeAccount == request.Id
                               orderby Child.KodeAccount
                               select new
                               {
                                   NoUrutAccountId = Child.Id,
                                   DataAkun = "[" + Child.KodeAccount + "] - " + Child.Account + " - " + Analyze(Child.Kelompok) + " - " + NormalPos(Child.NormalPos)

                               }).ToListAsync(cancellationToken);
                //var model = new GetDataAccountByParent2ViewModel
                //{
                //    DataAccountParentDs = _mapper.Map<IEnumerable<GetDataAccountByParent2LookUpModel>>(aa)
                //};
                //return model;
                var model = new GetDataAccountByParent2ViewModel
                {
                    DataAccountParentDs =    aa
                };
                return model;
             
                //return _database.AccountingDataAccount.ToListAsync(cancellationToken: cancellationToken);




            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error Getting Transactions List");
                throw;
            }
        }

        static String Analyze(String value)
        {
            // Return a value for each argument.
            switch (value)
            {
                case "N":
                    return "NERACA";
                case "L":
                    return "Laba/Rugi";

                default:
                    return String.Empty;
            }
        }
        static String NormalPos(int? value)
        {
            // Return a value for each argument.
            switch (value)
            {
                case 1:
                    return "DEBIT";
                case -1:
                    return "KREDIT";

                default:
                    return String.Empty;
            }
        }

    }
}
