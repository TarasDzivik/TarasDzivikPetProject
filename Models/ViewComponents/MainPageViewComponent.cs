using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TarasDzivikPetProject.Domain;

namespace TarasDzivikPetProject.Models.ViewComponents
{
    public class MainPageViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public MainPageViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)
                View("Default", dataManager.VehicleItems.GetVehicleItem()));
            // замінити GetVehicleItem() на GetVehicleItemByType()
        }
    }
}