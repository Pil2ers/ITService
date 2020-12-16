using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITServiceAPI.Helpers;
using ITServiceAPI.Services;
using ITServiceAPI.Services.Interface;
using ITServiceModel.Models;

namespace ITServiceAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class CustomersController : ControllerBase
    //{
    //    private readonly ICustomersService _customersService;
    //    public CustomersController()
    //    {
    //        this._customersService = new CustomersService(new NorthwindContext());
    //    }
    //    [HttpGet]
    //    [Route("GetCustomers")]
    //    public async Task<ActionResult> GetCustomers()
    //    {
    //        return Ok(await _customersService.GetCustomers());
    //    }
    //    [Authorize]
    //    [HttpPost]
    //    [Route("InsertCustomers")]
    //    public async Task<IActionResult> InsertCustomers(Customers customers)
    //    {
    //        await _customersService.InsertCustomers(customers);
    //        return Ok();
    //    }
    //    [HttpPut]
    //    [Route("UpdateCustomers")]
    //    public async Task<ActionResult> UpdateCustomers(string id, Customers customers)
    //    {
    //        if (id != customers.CustomerId)
    //        {
    //            return BadRequest();
    //        }

    //        try
    //        {
    //            await _customersService.UpdateCustomers(customers);

    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!_customersService.CustomersExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }

    //        }
    //        return NoContent();
    //    }
    //    [HttpDelete]
    //    [Route("DeleteCustomers/{id}")]
    //    public async Task<ActionResult> DeleteCustomers(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }
    //        await _customersService.DeleteCustomers(id);
    //        return Ok();
    //    }
    
    //}
}
