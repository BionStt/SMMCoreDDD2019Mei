using Dapper;
using MediatR;
using SumberMas2015.Organization.InfrastructureData.Context;
using SumberMas2015.Organization.InfrastructureData.Dapper;
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
      
        private readonly IDbConnectionFactory _connectionFactory;

        public CreateProsesBisnisCommandHandler(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory=connectionFactory;
        }

        public async Task<Unit> Handle(CreateProsesBisnisCommand request, CancellationToken cancellationToken)
        {
            var parameters = new DynamicParameters();

            parameters.Add("KodeProsesBisnis", request.KodeProsesBisnis);
            parameters.Add("NamaProsesBisnis", request.NamaProsesBisnis);
            parameters.Add("Aktif", request.Aktif);

            if (request.Parent != "0")
            {
                parameters.Add("Parent", request.Parent);
            }
            else
            {
                parameters.Add("Parent", (string)null);
            }

            var sql = "INSERT INTO DataPerusahaanProsesBisnis(KodeProsesBisnis, NamaProsesBisnis, Aktif,Parent) VALUES(@KodeProsesBisnis, @NamaProsesBisnis, @Aktif, @Parent)";

            using (var conn = _connectionFactory.GetDbConnection())
            {
                await conn.QueryAsync(sql, parameters);

            }

            return Unit.Value;
        }
    }
}
