using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TarasDzivikPetProject.Domain;
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

        public VehicleItem GetVehicleItemById(Guid id)
        {
            return context.VehicleItem.FirstOrDefault(x => x.Id == id);
        }

        public void SaveVehicleItem(VehicleItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteVehicleItem(Guid id)
        {
            context.VehicleItem.Remove(new VehicleItem() { Id = id });
            context.SaveChanges();
        }
    }
}