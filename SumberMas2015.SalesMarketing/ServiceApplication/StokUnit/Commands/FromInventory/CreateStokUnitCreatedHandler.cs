using MediatR;
using SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.CreateStokUnit;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Commands.FromInventory
{
    public class CreateStokUnitCreatedHandler : INotificationHandler<CreateStokUnitCreated>
    {
        private readonly SalesMarketingContext _context;

        public CreateStokUnitCreatedHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task Handle(CreateStokUnitCreated notification, CancellationToken cancellationToken)
        {
            var dtStokunit = Domain.StokUnit.CreateStokUnit(notification.StokUnitId, notification.MasterBarangId, notification.NomorRangka, notification.NomorMesin, notification.NamaSupplier);

            await _context.StokUnit.AddAsync(dtStokunit);
            await _context.SaveChangesAsync();

        }
    }
}
