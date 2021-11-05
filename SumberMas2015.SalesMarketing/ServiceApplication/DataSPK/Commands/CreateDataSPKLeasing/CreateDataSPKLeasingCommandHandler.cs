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

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKLeasing
{
    public class CreateDataSPKLeasingCommandHandler : IRequestHandler<CreateDataSPKLeasingCommand, Guid>
    {
        private readonly SalesMarketingContext _context;
        private IMediator _mediator;

        public CreateDataSPKLeasingCommandHandler(SalesMarketingContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateDataSPKLeasingCommand request, CancellationToken cancellationToken)
        {
            var sales = await _context.DataSalesMarketing.Where(x => x.NoUrutId == request.NamaSales).Select(x=>x.DataSalesMarketingId).SingleOrDefaultAsync();

            //var dtSPK = await _context.DataSPK.Where(x => x.NoUrutId == request.DataSPKId).SingleOrDefaultAsync();
            //dtSPK.AddDataSPKLeasing(request.Angsuran, request.Mediator, request.NamaCMO,sales, request.Tenor, request.TanggalSurvei);

            //  await _context.DataSPK.AddAsync(dtSPK);
            var dtSPKId = await _context.DataSPK.Where(x => x.NoUrutId == request.DataSPKId).Select(x=>x.DataSPKId).SingleOrDefaultAsync();

            var dtSPKLeasing = Domain.DataSPKLeasing.CreateDataSPKLeasing(request.Angsuran, request.Mediator, request.NamaCMO, sales, request.Tenor, request.TanggalSurvei, dtSPKId);

            await _context.DataSPKLeasing.AddAsync(dtSPKLeasing);
            await _context.SaveChangesAsync();

            return dtSPKLeasing.DataSPKLeasingId;
           // return dtSPK.

        }
    }
}
