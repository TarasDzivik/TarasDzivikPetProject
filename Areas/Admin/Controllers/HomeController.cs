using Microsoft.AspNetCore.Mvc;
using TarasDzivikPetProject.Domain;

namespace TarasDzivikPetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            // Для прикладу виведемо на сторінку адмінки список всіх послуг які в нас є на сайті
            return View(dataManager.VehicleItems.GetVehicleItem());
        }
    }
}