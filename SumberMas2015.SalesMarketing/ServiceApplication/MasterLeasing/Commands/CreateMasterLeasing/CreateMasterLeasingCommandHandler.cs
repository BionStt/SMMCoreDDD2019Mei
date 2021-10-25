using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Commands.CreateMasterLeasing
{
    public class CreateMasterLeasingCommandHandler : IRequestHandler<CreateMasterLeasingCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreateMasterLeasingCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateMasterLeasingCommand request, CancellationToken cancellationToken)
        {
            var mstLeasing = Domain.MasterLeasing.Create(request.NamaLeasing);

            await _context.MasterLeasing.AddAsync(mstLeasing);
            await _context.SaveChangesAsync();

            return mstLeasing.MasterLeasingId;

        }
    }
}
