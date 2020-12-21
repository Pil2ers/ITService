using ITServiceModel;
using ITServiceModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITServiceAPI.Services.Interface
{
    public interface IUserAccountService
    {
        Task ActiveStatus(UserAccount userAccount);
        Task UpdatedetailUserAccount(UserAccount userAccount);
        Task<IEnumerable<UserAccount>> GetAllUserAccount();
        Task <List<UserAccount>>GetUserAccountId(UserAccount userAccount);
        bool UserAccountExists(string id);
    }
}