using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using TarasDzivikPetProject.Domain;
using TarasDzivikPetProject.Domain.Entities;
using TarasDzivikPetProject.Service;
using System.IO;

namespace TarasDzivikPetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VehicleItemController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public VehicleItemController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Edit(int id) // По ідентифікатору ми шукаємо послугу в БД. Якщо не знайдена то ми створюємо нову.
        {
            var entity = id == default ? new VehicleItem() : dataManager.VehicleItems.GetVehicleItemById(id);
            return View(entity);
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult Edit(VehicleItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "images/", titleImageFile.FileName),
                            FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.VehicleItems.SaveVehicleItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        [Area("Admin")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.VehicleItems.DeleteVehicleItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}