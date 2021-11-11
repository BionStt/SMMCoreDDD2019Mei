using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPK
{
    public class CreateDataSPKCommandHandler : IRequestHandler<CreateDataSPKCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreateDataSPKCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataSPKCommand request, CancellationToken cancellationToken)
        {
            var dtSPK = Domain.DataSPK.CreateDataSPKBaru(request.NamaLokasi,  request.UserName,request.UserNameId);

            await _context.DataSPK.AddAsync(dtSPK);
            await _context.SaveChangesAsync();

            return dtSPK.DataSPKId;
        }
    }
}
