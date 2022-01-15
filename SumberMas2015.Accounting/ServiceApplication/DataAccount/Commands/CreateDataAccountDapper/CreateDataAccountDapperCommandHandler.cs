using Dapper;
using MediatR;
using SumberMas2015.Accounting.Infrastructure.Dapper;
using SumberMas2015.Accounting.ServiceApplication.DataJournalDetails.Commands.CreateSaldoAwal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Commands.CreateDataAccountDapper
{
    public class CreateDataAccountDapperCommandHandler : IRequestHandler<CreateDataAccountDapperCommand, Guid>
    {
        private readonly IDbConnectionFactory _connectionFactory;
        private readonly IMediator _mediator;

        public CreateDataAccountDapperCommandHandler(IDbConnectionFactory connectionFactory, IMediator mediator)
        {
            _connectionFactory = connectionFactory;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateDataAccountDapperCommand request, CancellationToken cancellationToken)
        {
            var xx = Guid.NewGuid();
            var parameters = new DynamicParameters();
            parameters.Add("KodeAccount", request.KodeAccount);
            parameters.Add("Account", request.Account.ToUpper());
            parameters.Add("NormalPos", request.NormalPos);
            parameters.Add("Kelompok", request.Kelompok);
            parameters.Add("DataAccountId", xx);


            if (request.Parent != "0")
            {
                parameters.Add("Parent", request.Parent);
            }
            else
            {
                parameters.Add("Parent", (string)null);
            }

            var sql = "INSERT INTO DataAccount(KodeAccount, Account, NormalPos, Kelompok, DataAccountId,Parent) VALUES(@KodeAccount, @Account, @NormalPos, @Kelompok, @DataAccountId,@Parent)";

            using (var conn = _connectionFactory.GetDbConnection())
            {
                await conn.QueryAsync(sql, parameters);

            }
            // var entity = Domain.DataAccount.CreateDataAccount(request.Parent, request.KodeAccount, request.Account, request.NormalPos, request.Kelompok);

            await _mediator.Publish(new CreateSaldoAwalCommand { DataAccountId = xx, Debit=0, Kredit=0 });

            return xx;

            //var sql = "INSERT INTO Employee(Name) "
            //       + "VALUES(@Name)";
            //var parameters = new DynamicParameters();
            //parameters.Add("@Name", entity.Name, System.Data.DbType.String);

            //using (var conn = _connectionFactory.GetDbConnection())
            //{
            //    await conn.ExecuteAsync(@"
            //        INSERT INTO Book (Title, Author) 
            //        VALUES (@Title, @Author);
            //    ", command);
            //    await conn.QueryAsync(sql, parameters);
            //}

            //const string sql = @" insert into dbo.Product (Name)
            //            values (@Name);
            //            SELECT CAST(SCOPE_IDENTITY() as int)";

            //using (var connection = _dataAccess.GetOpenConnection())
            //{
            //    var id = connection.Query<int>(sql, new { Name = name }).Single();
            //    return id;



        }
    }
}
