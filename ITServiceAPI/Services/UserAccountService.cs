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
        public async Task<List<UserAccount>> GetUserAccountId(UserAccount userAccount)
        {
            return await Task.Run(() => _iTServiceContext.UserAccount.Where(p => p.EMP_ID == userAccount.EMP_ID).ToListAsync());
        }

        public async Task UpdatedetailUserAccount(UserAccount userAccount)
        {
            var ad = _iTServiceContext.UserAccount.Where(p => p.EMP_ID == userAccount.EMP_ID).FirstOrDefault();
            ad.EMP_NAME = userAccount.EMP_NAME;
            ad.EMP_LASTNAME = userAccount.EMP_LASTNAME;
            ad.EMP_NAMETH = userAccount.EMP_NAMETH;
            ad.EMP_LASTNAMETH = userAccount.EMP_LASTNAMETH;
            ad.EMP_NICKNAME = userAccount.EMP_NICKNAME;
            ad.EMP_NICKNAMETH = userAccount.EMP_NICKNAMETH;
            ad.EMP_TEL = userAccount.EMP_TEL;
            ad.EMP_DEPT = userAccount.EMP_DEPT;
            await _iTServiceContext.SaveChangesAsync();

        }

        public bool UserAccountExists(string id)
        {
            return _iTServiceContext.UserAccount.Any(e => e.EMP_ID == id);
        }
    }
    
}
