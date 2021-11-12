using MediatR;
using SumberMas2015.Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterBarang.Commands.FromInventory
{
    public class CreateMasterBarangCreatedHandler : INotificationHandler<CreateMasterBarangCreated>
    {
        private readonly SalesMarketingContext _context;

        public CreateMasterBarangCreatedHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task Handle(CreateMasterBarangCreated notification, CancellationToken cancellationToken)
        {
            var dtMasterbarang = Domain.MasterBarang.Create(notification.NamaBarang, notification.NomorRangka, notification.NomorMesin, notification.Merek,
                notification.KapasitasMesin, notification.HargaOffTheRoad, notification.BBN, notification.TahunPerakitan, notification.TypeKendaraan);



            await _context.MasterBarang.AddAsync(dtMasterbarang);
            await _context.SaveChangesAsync();

        }
    }
}
