using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Commands.CreateDataPenjualanDetail
{
    public class CreateDataPenjualanDetailCommandHandler : IRequestHandler<CreateDataPenjualanDetailCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreateDataPenjualanDetailCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataPenjualanDetailCommand request, CancellationToken cancellationToken)
        {
            var dtPenjualanId = Guid.NewGuid();
            var StokUnitId = Guid.NewGuid();


            var dtDataPenjualanDetail = Domain.DataPenjualanDetail.CreateDataPenjualanDetail(dtPenjualanId, StokUnitId, request.offTheRoad, request.bBN, request.hargaOTR, request.uangMuka,
                request.diskonKredit, request.diskonTunai, request.subsidi, request.promosi, request.komisi, request.joinPromo1, request.joinPromo2, request.sPF, request.sellOut, request.dendaWilayah);


            await _context.DataPenjualanDetail.AddAsync(dtDataPenjualanDetail);
            await _context.SaveChangesAsync();

            return dtDataPenjualanDetail.DataPenjualanDetailId;
        }
    }
}
