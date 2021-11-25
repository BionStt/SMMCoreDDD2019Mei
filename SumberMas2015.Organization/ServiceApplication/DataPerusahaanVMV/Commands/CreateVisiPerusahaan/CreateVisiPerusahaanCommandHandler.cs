using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanVMV.Commands.CreateVisiPerusahaan
{
    public class CreateVisiPerusahaanCommandHandler : IRequestHandler<CreateVisiPerusahaanCommand>
    {
        private readonly OrganizationContext _context;

        public CreateVisiPerusahaanCommandHandler(OrganizationContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateVisiPerusahaanCommand request, CancellationToken cancellationToken)
        {
            var dtVisi = Domain.DataPerusahaanVisi.CreateVisi(request.Visi);

            await _context.DataPerusahaanVisi.AddAsync(dtVisi);
            await _context.SaveChangesAsync();

            return Unit.Value;


        }
    }
}
