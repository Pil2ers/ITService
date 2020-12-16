using System.Collections.Generic;
using System.Threading.Tasks;
using ITServiceModel;
using ITServiceModel.Models;
using ITServiceAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ITServiceAPI.Services.Interface
{
    public class UserAccountService : IUserAccountService
    {
        public readonly ITServiceContext _iTServiceContext;
        public UserAccountService(ITServiceContext iTServiceContext)
        {
            _iTServiceContext = iTServiceContext;
        }
        public async Task ActiveStatus(UserAccount userAccount)
        {
            var  ad  = _iTServiceContext.UserAccount.Where(p => p.EMP_ID == userAccount.EMP_ID).FirstOrDefault();
            ad.ACTIVATE = userAccount.ACTIVATE;
            await _iTServiceContext.SaveChangesAsync();
        }

        public async Task <IEnumerable<UserAccount>> GetAllUserAccount()
        {
              return await Task.Run(() => _iTServiceContext.UserAccount.ToListAsync());
        }
        public bool UserAccountExists(string id)
        {
            return _iTServiceContext.UserAccount.Any(e => e.EMP_ID == id);
        }
    }
    
}
