using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITServiceAPI.Helpers;
using ITServiceAPI.Services.Interface;
using ITServiceModel.Models;
using System.Xml.Linq;
using ITServiceModel;

namespace ITServiceAPI.Services
{
    public class EquipmentService : IEquipmentService
    {

        public readonly ITServiceContext _iTServiceContext;
        public EquipmentService(ITServiceContext iTServiceContext)
        {
            _iTServiceContext = iTServiceContext;
        }
      
        public bool EquipmentExists(Guid guid)
        {
            return _iTServiceContext.Equipment.Any(e => e.EQUIPMENT_RECORD == guid);
        }

        public async Task<IEnumerable<Equipment>> GetEquipment()
        {
            return await Task.Run(() => _iTServiceContext.Equipment.ToListAsync());
        }
    }
}