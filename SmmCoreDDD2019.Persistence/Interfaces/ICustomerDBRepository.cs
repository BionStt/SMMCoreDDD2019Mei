using SmmCoreDDD2019.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Persistence.Interfaces
{
    public interface ICustomerDBRepository : IBaseRepository<CustomerDB>
    {
        Task<CustomerDB> GetById(string id);
        Task<List<CustomerDB>> GetByName(string name);
    }
}
