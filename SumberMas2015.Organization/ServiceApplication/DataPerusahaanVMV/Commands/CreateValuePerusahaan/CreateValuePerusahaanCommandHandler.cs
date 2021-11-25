using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanVMV.Commands.CreateValuePerusahaan
{
    public class CreateValuePerusahaanCommandHandler : IRequestHandler<CreateValuePerusahaanCommand>
    {
        private readonly OrganizationContext _context;

        public CreateValuePerusahaanCommandHandler(OrganizationContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateValuePerusahaanCommand request, CancellationToken cancellationToken)
        {
            var dtValue = Domain.DataPerusahaanValue.CreateValue(request.ValuePerusahaan);

            await _context.DataPerusahaanValue.AddAsync(dtValue);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
