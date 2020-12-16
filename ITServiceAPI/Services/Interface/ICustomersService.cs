using System.Collections.Generic;
using System.Threading.Tasks;
using ITServiceModel.Models;

namespace ITServiceAPI.Services.Interface
{
    public interface ICustomersService 
    {
        Task <IEnumerable<Customers>> GetCustomers();
        Task InsertCustomers(Customers customers);
        Task UpdateCustomers(Customers customers);
        Task DeleteCustomers(string id);
        bool CustomersExists(string id);
      
    }
}
