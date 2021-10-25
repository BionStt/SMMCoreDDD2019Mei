using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Commands.CreateMasterLeasingCabang
{
    public class CreateMasterLeasingCabangCommandHandler : IRequestHandler<CreateMasterLeasingCabangCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreateMasterLeasingCabangCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateMasterLeasingCabangCommand request, CancellationToken cancellationToken)
        {
            var mstLeasingCabang = Domain.MasterLeasingCabang.Create(request.NamaCabangLeasing, request.EmailCabang, request.AlamatLeasingCabang);

            await _context.MasterLeasingCabang.AddAsync(mstLeasingCabang);
            await _context.SaveChangesAsync();
            return mstLeasingCabang.MasterLeasingCabangId;
        }
    }
}
