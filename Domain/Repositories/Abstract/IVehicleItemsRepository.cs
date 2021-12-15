using System.Linq;
using TarasDzivikPetProject.Domain.Entities;

namespace TarasDzivikPetProject.Domain.Repositories.Abstract
{
    public interface IVehicleItemsRepository
    {
        IQueryable<VehicleItem> GetVehicleItem();
        IQueryable<VehicleItem> GetVehicleItemsByFuelType(string fuel);
        IQueryable<VehicleItem> GetVehicleItemsByCategory(string type);
        VehicleItem GetVehicleItemById(int id);
        void SaveVehicleItem(VehicleItem entity);
        void DeleteVehicleItem(int id);
    }
}