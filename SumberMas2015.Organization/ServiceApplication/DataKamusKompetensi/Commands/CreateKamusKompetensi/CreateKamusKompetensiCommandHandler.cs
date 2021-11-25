using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataKamusKompetensi.Commands.CreateKamusKompetensi
{
    public class CreateKamusKompetensiCommandHandler : IRequestHandler<CreateKamusKompetensiCommand>
    {
        private readonly OrganizationContext _context;

        public CreateKamusKompetensiCommandHandler(OrganizationContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateKamusKompetensiCommand request, CancellationToken cancellationToken)
        {
            var dtKamusKompetensi = Domain.DataKamusKompetensi.CreateDataKamusKompetensi(request.NamaKamusKompetensi, request.Penjelasan);

            await _context.DataKamusKompetensi.AddAsync(dtKamusKompetensi);
            await _context.SaveChangesAsync();

            return Unit.Value;
        
        
        }
    }
}
