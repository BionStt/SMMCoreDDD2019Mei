using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.SalesMarketing.Commands.CreateNamaSales
{
    public class CreateNamaSalesCommandHandler : IRequestHandler<CreateNamaSalesCommand>
    {
        private readonly SalesMarketingContext _context;

        public CreateNamaSalesCommandHandler(SalesMarketingContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateNamaSalesCommand request, CancellationToken cancellationToken)
        {
            var dtSales = new Domain.DataSalesMarketing();
            dtSales.NamaSales = request.NamaSales;
            dtSales.DataSalesMarketingId = request.DataSalesMarketingId;
            await _context.DataSalesMarketing.AddAsync(dtSales);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
