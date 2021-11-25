using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanProsesBisnis.CreateProsesBisnis
{
    public class CreateProsesBisnisCommandHandler : IRequestHandler<CreateProsesBisnisCommand>
    {
        private readonly OrganizationContext _context;

        public CreateProsesBisnisCommandHandler(OrganizationContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateProsesBisnisCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
