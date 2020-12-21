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
    public class EquipmentController : Controller
    {
        private readonly IEquipmentService _equipmentService;
        public EquipmentController()
        {
            this._equipmentService = new EquipmentService(new ITServiceContext());
        }

        [HttpGet]
        [Route("GetEquipment")]
        public async Task<ActionResult> GetEquipment()
        {
            return Ok(await _equipmentService.GetEquipment());
        }
      
    }
}
