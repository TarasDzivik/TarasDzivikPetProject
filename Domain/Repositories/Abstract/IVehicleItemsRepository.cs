using System.Linq;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.Repositories.Abstract
{
    public interface IVehicleItemsRepository
    {
        IQueryable<VehicleItem> GetVehicleItem();
        IOrderedEnumerable<VehicleItem> GetVehicleItemsByFuelType(string fuel);
        IQueryable<VehicleItem> GetVehicleItemsByType(string type);
        VehicleItem GetVehicleItemById(int id);
        void SaveVehicleItem(VehicleItem entity);
        void DeleteVehicleItem(int id);
    }
}