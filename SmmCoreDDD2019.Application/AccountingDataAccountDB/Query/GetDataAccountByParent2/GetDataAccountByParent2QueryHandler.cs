using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;
namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent2
{
    public class GetDataAccountByParent2QueryHandler : IRequestHandler<GetDataAccountByParent2Query, GetDataAccountByParent2ViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataAccountByParent2QueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataAccountByParent2ViewModel> Handle(GetDataAccountByParent2Query request, CancellationToken cancellationToken)
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
            var model = new GetDataAccountByParent2ViewModel
            {
                DataAccountParentDs = _mapper.Map<IEnumerable<GetDataAccountByParent2LookUpModel>>(aa)
            };
            return model;

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
