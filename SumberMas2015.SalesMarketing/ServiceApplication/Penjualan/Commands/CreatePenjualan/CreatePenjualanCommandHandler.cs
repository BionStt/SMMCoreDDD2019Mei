using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.Penjualan.Commands.CreatePenjualan
{
    public class CreatePenjualanCommandHandler : IRequestHandler<CreatePenjualanCommand, Guid>
    {
        private readonly SalesMarketingContext _context;
        private IMediator _mediator;

        public CreatePenjualanCommandHandler(SalesMarketingContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreatePenjualanCommand request, CancellationToken cancellationToken)
        {
            var dtSPKId = Guid.NewGuid();
            var dtKonsumen= Guid.NewGuid();
            var mstLeasingCabang = Guid.NewGuid();
            var salesId = Guid.NewGuid();
            var mstKategoriPenjualan = Guid.NewGuid();

            var dtPenjualan = Domain.DataPenjualan.CreateDataPenjualan(dtSPKId, dtKonsumen, mstLeasingCabang,request.NoBuku,
                salesId,request.Keterangan, mstKategoriPenjualan,request.Mediator,request.UserNameInput);

            await _context.DataPenjualan.AddAsync(dtPenjualan);
            await _context.SaveChangesAsync();

            return dtPenjualan.DataPenjualanId;
        }
    }
}
