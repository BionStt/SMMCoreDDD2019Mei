using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.IntegrationEvent;
using SumberMas2015.Inventory.EventBus;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.CreateStokUnit
{
    public class CreateStokUnitCommandHandler : IRequestHandler<CreateStokUnitCommand, Guid>
    {
        private readonly InventoryContext _context;
       // private readonly IMediator _mediator;
        private readonly IInventoryEventBus _eventBus;

        public CreateStokUnitCommandHandler(InventoryContext context, IInventoryEventBus eventBus)
        {
            _context = context;
            _eventBus=eventBus;
        }

        public async Task<Guid> Handle(CreateStokUnitCommand request, CancellationToken cancellationToken)
        {
            var pembelianDetailId = await _context.PembelianDetail.Where(x => x.NoUrutId==request.pembelianDetailId).Select(x => x.PembelianDetailId).SingleOrDefaultAsync();
            var masterBarangId = await _context.MasterBarang.Where(x => x.NoUrutId==request.masterBarangId).Select(x => x.MasterBarangId).SingleOrDefaultAsync();
     

            var dtStokUnit = Domain.StokUnit.CreateStokUnit(pembelianDetailId, masterBarangId, request.NomorRangka, request.NomorMesin,
                request.Warna, request.Harga, request.Diskon, request.Sellin);

            await _context.StokUnit.AddAsync(dtStokUnit);

            await _eventBus.Publish(new StokUnitAddedIntegrationEvent(
                dtStokUnit.StokUnitId,
                masterBarangId,
                request.NomorRangka,
                request.NomorMesin,
                request.NamaSupplier,
                request.Warna
                ));

          //  await _context.SaveChangesAsync();

            //await _mediator.Publish(new CreateStokUnitCreated { 
            //MasterBarangId = masterBarangId,
            //NamaSupplier = request.NamaSupplier,
            //NomorMesin  = request.NomorMesin,
            //NomorRangka = request.NomorRangka,
            //StokUnitId = dtStokUnit.StokUnitId
            //} );
            return dtStokUnit.StokUnitId;
        }
    }
}
