using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanFaktur.Commands.CreatePermohonanFaktur
{
    public class CreatePermohonanFakturCommandHandler : IRequestHandler<CreatePermohonanFakturCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreatePermohonanFakturCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePermohonanFakturCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
