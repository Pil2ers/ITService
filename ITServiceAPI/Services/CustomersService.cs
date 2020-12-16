using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITServiceAPI.Helpers;
using ITServiceAPI.Services.Interface;
using ITServiceModel.Models;
using System.Xml.Linq;

namespace ITServiceAPI.Services
{
    public class CustomersService : ICustomersService
    {

        public readonly NorthwindContext _northwindContext;
        public CustomersService(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        public async Task DeleteCustomers(string id)
        {
            Customers customers = _northwindContext.Customers.Where(p => p.CustomerId == id).FirstOrDefault();
            _northwindContext.Customers.Remove(customers);
            await _northwindContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Customers>> GetCustomers()
        {
            
            return await Task.Run(() => _northwindContext.Customers.ToListAsync()); 
        }
        public async Task InsertCustomers(Customers customers)
        {
            //if (!_northwindContext.Customers.Any(p => p.CustomerId == customers.CustomerId))
            //{
                _northwindContext.Customers.Add(customers);
                await _northwindContext.SaveChangesAsync();
               
           // }
          
        }
        public async Task UpdateCustomers(Customers customers)
        {
            _northwindContext.Entry(customers).State = EntityState.Modified;
            await _northwindContext.SaveChangesAsync();
        }
        public bool CustomersExists(string id)
        {
            return _northwindContext.Customers.Any(e => e.CustomerId == id);
        }
    }
}