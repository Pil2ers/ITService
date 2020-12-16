using System.Collections.Generic;
using System.Threading.Tasks;
using ITServiceModel.Models;

namespace ITServiceAPI.Services.Interface
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
