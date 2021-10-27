using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanCabang.Commands.CreateDataPerusahaanCabang
{
    public class CreateDataPerusahaanCabangCommandHandler : IRequestHandler<CreateDataPerusahaanCabangCommand, Guid>
    {
        private readonly OrganizationContext _context;

        public CreateDataPerusahaanCabangCommandHandler(OrganizationContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataPerusahaanCabangCommand request, CancellationToken cancellationToken)
        {
            var dtPerusahaanCabang = Domain.DataPerusahaanCabang.CreateDataPerusahaanCabang(request.DataPerusahaanId,request.NamaPerusahaanCabang,request.AlamatPerusahaanCabang,request.PenanggungJawab);

            await _context.DataPerusahaanCabang.AddAsync(dtPerusahaanCabang);
            await _context.SaveChangesAsync();
            return dtPerusahaanCabang.DataPerusahaanCabangId;
        }
    }
}
