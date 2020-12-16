using ITServiceModel;
using ITServiceModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITServiceAPI.Services.Interface
{
    public interface IUserAccountService
    {
        Task ActiveStatus(UserAccount userAccount);
        Task<IEnumerable<UserAccount>> GetAllUserAccount();
        bool UserAccountExists(string id);
    }
}