using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanVMV.Commands.CreateMisiPerusahaan
{
    public class CreateMisiPerusahaanCommandHandler : IRequestHandler<CreateMisiPerusahaanCommand>
    {
        private readonly OrganizationContext _context;

        public CreateMisiPerusahaanCommandHandler(OrganizationContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateMisiPerusahaanCommand request, CancellationToken cancellationToken)
        {
            var dtMisiPerusahaan = Domain.DataPerusahaanMisi.CreateMisi(request.Misi);

            await _context.DataPerusahaanMisi.AddAsync(dtMisiPerusahaan);
            await _context.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
