using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Infrastructure.Dapper
{
    public class DapperConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DapperConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetDbConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
