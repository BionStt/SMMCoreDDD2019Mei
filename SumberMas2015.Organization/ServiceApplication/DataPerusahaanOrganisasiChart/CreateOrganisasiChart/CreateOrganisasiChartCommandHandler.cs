using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanOrganisasiChart.CreateOrganisasiChart
{
    public class CreateOrganisasiChartCommandHandler : IRequestHandler<CreateOrganisasiChartCommand>
    {
        private readonly OrganizationContext _context;
        private readonly IDbConnectionFactory _connectionFactory;
        public CreateOrganisasiChartCommandHandler(OrganizationContext context)
        {
            _context=context;
        }

        public async Task<Unit> Handle(CreateOrganisasiChartCommand request, CancellationToken cancellationToken)
        {
            var dtOrganisasi = Domain.DataPerusahaanOrganisasiChart.CreateStrukturOrganisasi();
        }
    }
}
