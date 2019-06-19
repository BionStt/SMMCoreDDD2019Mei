using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent
{
    public class GetDataAccountByParentQueryHandler : IRequestHandler<GetDataAccountByParentQuery, GetDataAccountByParentViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataAccountByParentQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataAccountByParentViewModel> Handle(GetDataAccountByParentQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.AccountingDataAccount
                            orderby a.KodeAccount
                            where (a.Parent==null)
                            select new
                            {
                                NoUrutAccountId = a.NoUrutAccountId,
                                DataAkun = "[" + a.KodeAccount + "] - " + a.Account + " - " + Analyze(a.Kelompok) + " - " + NormalPos(a.NormalPos)


                            }).ToListAsync(cancellationToken);
            var model = new GetDataAccountByParentViewModel
            {
                DataAccountParentDs = _mapper.Map<IEnumerable<GetDataAccountByParentLookUpModel>>(aa)
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
