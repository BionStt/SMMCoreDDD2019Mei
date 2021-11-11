using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.DataSPKById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKredit
{
    public class CreateDataSPKKreditCommandHandler : IRequestHandler<CreateDataSPKKreditCommand, Guid>
    {
        private readonly SalesMarketingContext _context;
        private  IMediator _mediator;

        public CreateDataSPKKreditCommandHandler(SalesMarketingContext context, IMediator mediator )
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateDataSPKKreditCommand request, CancellationToken cancellationToken)
        {
            var dtSPK = await _context.DataSPK.Where(x => x.NoUrutId == request.DataSPKId).Select(x=>x.DataSPKId).SingleOrDefaultAsync();

            var dtSPKKredit = Domain.DataSPKKredit.CreateDataSPKKredit(request.BiayaAdministrasiKredit,
                request.BiayaAdministrasiTunai, request.BBN, request.DendaWilayah, request.DiskonDP, request.DiskonTunai,
                request.DPPriceList, request.Komisi, request.OffTheRoad, request.Promosi, request.UangTandaJadiTunai, 
                request.UangTandaJadiTunai, dtSPK,request.UserName,request.UserNameId);

            await _context.DataSPKKredit.AddAsync(dtSPKKredit);
            await _context.SaveChangesAsync();

            return dtSPKKredit.DataSPKKreditId;

        }
    }
}
