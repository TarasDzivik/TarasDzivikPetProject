using Microsoft.EntityFrameworkCore;
using System.Linq;
using TarasDzivikPetProject.Domain.Entities;
using TarasDzivikPetProject.Domain.Repositories.Abstract;

namespace TarasDzivikPetProject.Domain.Repositories.EntityFramework
{
    public class EFVehicleItemsRepository : IVehicleItemsRepository
    {
        private readonly AppDbContext context;

        public EFVehicleItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<VehicleItem> GetVehicleItem()
        {
            return context.VehicleItem;
        }

        public VehicleItem GetVehicleItemById(int id)
        {
            return context.VehicleItem.FirstOrDefault(x => x.VehicleId == id);
        }

        public void SaveVehicleItem(VehicleItem entity)
        {
            if (entity.VehicleId == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteVehicleItem(int id)
        {
            context.VehicleItem.Remove(new VehicleItem() { VehicleId = id });
            context.SaveChanges();
        }

        public VehicleItem GetLustVehicleItem(int id)
        {
            return context.VehicleItem
                .OrderByDescending(x => x.DateAdded)
                .FirstOrDefault(x => x.VehicleId == id);
        }

        public IOrderedEnumerable<VehicleItem> GetVehicleItemsByFuelType(string fuel)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<VehicleItem> GetVehicleItemsByType(string type)
        {
            throw new System.NotImplementedException();
        }
    }
}