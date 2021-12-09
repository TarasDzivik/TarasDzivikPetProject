using Microsoft.AspNetCore.Mvc;
using TarasDzivikPetProject.Domain;

namespace TarasDzivikPetProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult BuyVehicle()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("BuyVehicle"));
        }

        public IActionResult RentVehicle()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("RentVehicle"));
        }
        public IActionResult LoanCalculator()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("LoanCalculator"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("Contacts"));
        }
    }
}