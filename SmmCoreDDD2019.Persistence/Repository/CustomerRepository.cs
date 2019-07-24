using Microsoft.Extensions.Logging;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Persistence.Repository
{
    public class CustomerRepository : ICustomerDBRepository
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly ILogger _logger;

        public CustomerRepository(ISMMCoreDDD2019DbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger<CustomerRepository>();
        }

        public Task<int> Delete(CustomerDB obj)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerDB>> GetAll()
        {
            IEnumerable<CustomerDB> list = new List<CustomerDB>();

            try
            {
              list = _context.CustomerDB.OrderBy(x=>x.Nama).ToList();
            }
            catch (Exception ex)
            {
                if (this._logger != null) _logger.LogError(ex.Message);
            }

            return Task.FromResult(list.ToList());
        }

        public async Task<CustomerDB> GetById(string id)
        {
            CustomerDB obj = null;

            try
            {
                obj = await _context.CustomerDB.FindAsync(id);
               // obj =  _context.CustomerDB.Where(x => x.Id == Int32.Parse(id)).SingleOrDefault();
            }
            catch (Exception ex)
            {
                if (this._logger != null) _logger.LogError(ex.Message);
            }
            // return Task.FromResult(obj);
            return obj;
        }

        public Task<List<CustomerDB>> GetByName(string name)
        {
            IEnumerable<CustomerDB> list = new List<CustomerDB>();

            try
            {
    
              //  list = _context.CustomerDB.Where(x => name.Equals(x.Nama)).ToList();
                list = _context.CustomerDB.Where(x => x.Nama.Equals(name));
            }
            catch (Exception ex)
            {
                if (this._logger != null) _logger.LogError(ex.Message);
            }

            return Task.FromResult(list.ToList());
        }

        public Task<int> Save(CustomerDB obj)
        {
            throw new NotImplementedException();
        }

        //public Task<int> Save(CustomerDB obj)
        //{
        //    var result = 0;

        //    try
        //    {
        //        var sql = @"insert into customers (customer_id, name, address)
        //                    values (@customer_id, @name, @address)";

        //        result = _context.Conn.ExecuteAsync(sql, obj).Result;
        //    }
        //    catch (Exception ex)
        //    {
        //        if (this._logger != null) _logger.LogError(ex.Message);
        //    }

        //    return Task.FromResult(result);
        //}

        public Task<int> Update(CustomerDB obj)
        {
            throw new NotImplementedException();
        }
    }
}
