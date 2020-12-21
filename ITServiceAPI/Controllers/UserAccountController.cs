using AutoMapper;
using ITServiceAPI.Helpers;
using ITServiceAPI.Services;
using ITServiceAPI.Services.Interface;
using ITServiceModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : Controller
    {
        private readonly IUserAccountService _userAccount;
        public UserAccountController()
        {
            this._userAccount = new UserAccountService(new ITServiceContext());
        }

        [HttpGet]
        [Route("GetUserAccount")]
        public async Task<ActionResult> GetUserAccount()
        {

            return Ok(await _userAccount.GetAllUserAccount());
        }
        [HttpPut]
        [Route("ActiveStatus")]
        public async Task<ActionResult> ActiveStatus(UserAccount  userAccount)
        {

            UserAccount userAccount1 = new UserAccount();
            userAccount1.EMP_ID = userAccount.EMP_ID;
            userAccount1.ACTIVATE = userAccount.ACTIVATE;

            if (userAccount.EMP_ID != userAccount1.EMP_ID)
            {
                return BadRequest();
            }
            try
            {
                await _userAccount.ActiveStatus(userAccount1);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_userAccount.UserAccountExists(userAccount1.EMP_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpPost]
        [Route("UpdateDetialUserAccount")]
        public async Task<ActionResult> UpdateDetialUserAccount(UserAccount userAccount)
        {
            if(userAccount == null)
            {
                return BadRequest();
            }
            try
            {
                await _userAccount.UpdatedetailUserAccount(userAccount);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_userAccount.UserAccountExists(userAccount.EMP_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }
            return NoContent();
        }



        [HttpPost]
        [Route("GetUserAccountId")]
        public async Task<ActionResult> GetUserAccountId(UserAccount userAccount)
        {
            
            return Ok(await _userAccount.GetUserAccountId(userAccount));
        }
    }
}
