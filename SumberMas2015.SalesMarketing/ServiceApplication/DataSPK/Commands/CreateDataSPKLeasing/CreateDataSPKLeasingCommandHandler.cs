using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
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

        public CreateDataSPKLeasingCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataSPKLeasingCommand request, CancellationToken cancellationToken)
        {
            Guid sales = Guid.NewGuid();//nanti diganti dengan sales ya

            var dtSPKLeasing = Domain.DataSPKLeasing.CreateDataSPKLeasing(request.Angsuran, request.Mediator, request.NamaCMO, sales, request.Tenor);

            await _context.DataSPKLeasing.AddAsync(dtSPKLeasing);
            await _context.SaveChangesAsync();

            return dtSPKLeasing.DataSPKLeasingId;


        }
    }
}
