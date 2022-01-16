using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.IntegrationEvent;
using SumberMas2015.SalesMarketing.EventBus;
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
        //  private readonly InventoryContext _Inventorycontext;
        private readonly ISalesMarketingEventBus _eventBus;

        public CreateDataPenjualanDetailCommandHandler(SalesMarketingContext context, ISalesMarketingEventBus eventBus)
        {
            _context = context;
            _eventBus=eventBus;
        }

        public async Task<Guid> Handle(CreateDataPenjualanDetailCommand request, CancellationToken cancellationToken)
        {
            var dtPenjualanId = await _context.DataPenjualan.Where(x=>x.NoUrutId== request.dataPenjualanId).Select(x=>x.DataPenjualanId).SingleOrDefaultAsync();
           
            var StokUnitId = await _context.StokUnit.Where(x => x.NoUrutId == request.stokUnitId).SingleOrDefaultAsync();
            

            var dtDataPenjualanDetail = Domain.DataPenjualanDetail.CreateDataPenjualanDetail(dtPenjualanId, StokUnitId.StokUnitId, request.offTheRoad, request.bBN, request.hargaOTR, request.uangMuka,
                request.diskonKredit, request.diskonTunai, request.subsidi, request.promosi, request.komisi, request.joinPromo1, 
                request.joinPromo2, request.sPF, request.sellOut, request.dendaWilayah,request.UserNameId,request.UserName);

            StokUnitId.SetTerjual();
            _context.Entry(StokUnitId).Property(x => x.TanggalTerjual).IsModified=true;
            _context.Entry(StokUnitId).Property(x => x.Terjual).IsModified=true;

            await _context.DataPenjualanDetail.AddAsync(dtDataPenjualanDetail);

            _eventBus.Publish(new StokUnitSoldIntegrationEvent(StokUnitId.StokUnitId ));

          //  await _context.SaveChangesAsync();

            return dtDataPenjualanDetail.DataPenjualanDetailId;
        }
    }
}
