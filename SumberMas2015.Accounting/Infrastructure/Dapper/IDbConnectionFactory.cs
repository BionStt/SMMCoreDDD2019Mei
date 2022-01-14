using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SumberMas2015.Accounting.Infrastructure.Dapper
{
    public interface IDbConnectionFactory
    {
        IDbConnection GetDbConnection();
    }
}
