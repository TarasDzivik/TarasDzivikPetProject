using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.Repositories.Abstract
{
    public interface IVehicleItemsRepository
    {
        IQueryable<VehicleItem> GetVehicleItem();
        VehicleItem GetVehicleItemById(Guid id);
        void SaveVehicleItem(VehicleItem entity);
        void DeleteVehicleItem(Guid id);
    }
}
