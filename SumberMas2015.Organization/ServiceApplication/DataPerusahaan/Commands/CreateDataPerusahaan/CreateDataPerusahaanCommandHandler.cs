using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaan.Commands.CreateDataPerusahaan
{
    public class CreateDataPerusahaanCommandHandler : IRequestHandler<CreateDataPerusahaanCommand, Guid>
    {
        private readonly OrganizationContext _context;

        public CreateDataPerusahaanCommandHandler(OrganizationContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataPerusahaanCommand request, CancellationToken cancellationToken)
        {
            var dtPerusahaan = Domain.DataPerusahaan.CreateDataPerusahaan(request.NamaPerusahaan,request.AlamatPerusahaan,request.PenanggungJawab);

            await _context.DataPerusahaan.AddAsync(dtPerusahaan);
            await _context.SaveChangesAsync();


            return dtPerusahaan.DataPerusahaanId;
        }
    }
}
