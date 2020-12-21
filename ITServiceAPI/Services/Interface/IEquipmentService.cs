using System.Collections.Generic;
using System.Threading.Tasks;
using ITServiceModel;
using ITServiceModel.Models;

namespace ITServiceAPI.Services.Interface
{
    public interface IEquipmentService
    {
        Task <IEnumerable<Equipment>> GetEquipment();
        //Task InsertCustomers(Customers customers);
        //Task UpdateCustomers(Customers customers);
        //Task DeleteCustomers(string id);
        //bool CustomersExists(string id);
      
    }
}
