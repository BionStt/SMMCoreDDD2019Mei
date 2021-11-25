using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SumberMas2015.Organization.InfrastructureData.Dapper
{
    public interface IDbConnectionFactory
    {
        IDbConnection GetDbConnection();
    }
}
