using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Commands.FromInventory
{
    public class CreateStokUnitCommandHandler : IRequestHandler<CreateStokUnitCommand>
    {
        private readonly SalesMarketingContext _dbContext;

        public CreateStokUnitCommandHandler(SalesMarketingContext context)
        {
            _dbContext=context;
        }

        public async Task<Unit> Handle(CreateStokUnitCommand request, CancellationToken cancellationToken)
        {
            var DtStokUnit = Domain.StokUnit.CreateStokUnit(request.StokUnitId, request.MasterBarangId, request.NomorRangka, request.NomorMesin, request.NamaSupplier);

            await _dbContext.StokUnit.AddAsync(DtStokUnit);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;

            
        }
    }
}
