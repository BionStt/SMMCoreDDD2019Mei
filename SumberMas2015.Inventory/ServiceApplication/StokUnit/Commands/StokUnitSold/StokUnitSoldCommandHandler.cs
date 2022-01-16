using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.StokUnitSold
{
    public class StokUnitSoldCommandHandler : IRequestHandler<StokUnitSoldCommand>
    {
        private readonly InventoryContext _dbContext;

        public StokUnitSoldCommandHandler(InventoryContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task<Unit> Handle(StokUnitSoldCommand request, CancellationToken cancellationToken)
        {
            var stokUnit = await _dbContext.StokUnit.Where(x => x.StokUnitId == request.StokUnitId).SingleOrDefaultAsync();
            // var stokUnit = _dbContext.StokUnit.SingleOrDefaultAsync(x=>x.StokUnitId == request.StokUnitId);
            // var stokUnit = _dbContext.StokUnit.Where(x => x.StokUnitId == request.StokUnitId).ToListAsync();
            //   var aa = stokUnit.Result;
            stokUnit.SetTerjual();
            _dbContext.Entry(stokUnit).Property(x => x.Jual).IsModified=true;
            _dbContext.Entry(stokUnit).Property(x => x.TanggalTerjual).IsModified=true;
            //  await _dbContext.Update(stokUnit);

            await _dbContext.SaveChangesAsync();


                return Unit.Value;
        }





    }
}
