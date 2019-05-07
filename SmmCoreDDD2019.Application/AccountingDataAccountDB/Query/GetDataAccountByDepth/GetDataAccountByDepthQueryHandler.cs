using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Persistence;
using System.Threading;
namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByDepth
{
    public class GetDataAccountByDepthQueryHandler : IRequestHandler<GetDataAccountByDepthQuery, GetDataAccountByDepthViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataAccountByDepthQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataAccountByDepthViewModel> Handle(GetDataAccountByDepthQuery request, CancellationToken cancellationToken)
        {
            var aa = (from a in _context.AccountingDataAccount
                      from b in _context.AccountingDataAccount
                      where a.Parent == b.NoUrutAccountId.ToString() && (a.Depth==3)
                        
                      select new
                      {
                          NoUrutAccountId =  a.NoUrutAccountId,
                          Account =   b.Account,
                          KodeAccount =   a.KodeAccount,
                          DataAkun1= "[" + a.KodeAccount + "] - " + a.Account + " - " + Analyze(b.Kelompok) + " - " + NormalPos(b.NormalPos),
                          DataAkun2 = b.KodeAccount + " - " + b.Account + " - " + Analyze(b.Kelompok) + " - " + NormalPos(b.NormalPos)
                      }
                ).ToListAsync(cancellationToken);
                      
            var model = new GetDataAccountByDepthViewModel
            {
                DataAccountByDepthDS = _mapper.Map<IEnumerable<GetDataAccountByDepthLookUpModel>>(aa)
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
