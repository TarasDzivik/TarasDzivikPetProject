using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TarasDzivikPetProject.Domain;

namespace TarasDzivikPetProject.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.VehicleItems.GetVehicleItem()));
        }
    }
}