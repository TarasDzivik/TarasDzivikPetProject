using Microsoft.AspNetCore.Mvc;
using TarasDzivikPetProject.Domain;

namespace TarasDzivikPetProject.Controllers
{
    public class VehicleController : Controller
    {
        private readonly DataManager dataManager;
        public VehicleController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /* нижче логіка так, що ми очікуємо на вході параметр типу ІД.
         якщо ми не хочему якусь конкретну послугу, а усі, то дефолтне значення у нас пусте
        і відповідно пропускаємо ІФ провірку, через ВьюБеґ записуємо туди модель "PageServices"
        і в якості самої моделі для представлення в нас буде список всіх послуг (GetServiceItems)
        
        Мабуть правельніше було зробити список всіх послуг через вью/модел, но поки що залишу так*/

        public IActionResult Index(int id)
        {
            if (id != default)
            {
                return View("Show", dataManager.VehicleItems.GetVehicleItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.VehicleItems.GetVehicleItem());
        }
    }
}