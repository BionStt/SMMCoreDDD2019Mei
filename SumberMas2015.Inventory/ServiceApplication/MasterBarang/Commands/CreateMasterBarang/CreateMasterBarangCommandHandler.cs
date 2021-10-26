using MediatR;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang
{
    public class CreateMasterBarangCommandHandler : IRequestHandler<CreateMasterBarangCommand, Guid>
    {
        private readonly InventoryContext _context;

        public CreateMasterBarangCommandHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateMasterBarangCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = Domain.MasterBarang.Create(request.NamaBarang, request.NomorRangka, request.NomorMesin, request.Merek
                , request.KapasitasMesin, request.HargaOff, request.BBn, request.TahunPerakitan, request.TypeKendaraan);

            await _context.MasterBarang.AddAsync(mstBarang);
            await _context.SaveChangesAsync();

            return mstBarang.MasterBarangId;
        }
    }
}
