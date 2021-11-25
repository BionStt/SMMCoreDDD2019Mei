using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using SumberMas2015.Organization.InfrastructureData.Dapper;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanOrganisasiChart.CreateOrganisasiChart
{
    public class CreateOrganisasiChartCommandHandler : IRequestHandler<CreateOrganisasiChartCommand>
    {
        private readonly OrganizationContext _context;
        private readonly IDbConnectionFactory _connectionFactory;
        public CreateOrganisasiChartCommandHandler(OrganizationContext context, IDbConnectionFactory connectionFactory)
        {
            _context=context;
            _connectionFactory=connectionFactory;
        }

        public async Task<Unit> Handle(CreateOrganisasiChartCommand request, CancellationToken cancellationToken)
        {
            var parameters = new DynamicParameters();

            parameters.Add("KodeStrukturJabatan", request.KodeStrukturJabatan);
            parameters.Add("NamaStrukturJabatan", request.NamaStrukturJabatan);
            parameters.Add("LokasiJabatan", request.LokasiJabatan);

            if (request.Parent != "0")
            {
                parameters.Add("Parent", request.Parent);
            }
            else
            {
                parameters.Add("Parent", (string)null);
            }

            var sql = "INSERT INTO DataPerusahaanOrganisasiChart(KodeStrukturJabatan, NamaStrukturJabatan, LokasiJabatan,Parent) VALUES(@KodeStrukturJabatan, @NamaStrukturJabatan, @LokasiJabatan, @Parent)";

            using (var conn = _connectionFactory.GetDbConnection())
            {
                await conn.QueryAsync(sql, parameters);

            }

            return Unit.Value;
        }
    }
}
