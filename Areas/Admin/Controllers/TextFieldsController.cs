using Microsoft.AspNetCore.Mvc;
using TarasDzivikPetProject.Domain;
using TarasDzivikPetProject.Domain.Entities;
using TarasDzivikPetProject.Service;

namespace TarasDzivikPetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        public TextFieldsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        // Тут ми передаємо наше кодове слово, шукаємо його в БД і передаємо його у View
        public IActionResult Edit(string codeword)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeword); // З цим потім розберусь
            return View(entity);
        }

        [Area("Admin")]
        [HttpPost] // Тут нам приходить "TextField model"
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid) // Далі ми провіряємо її валідність
            {
                dataManager.TextFields.SaveTextField(model); /* зберігаємо в БД нашу "model" і перенеправляємо
                                                              * користувача в Areas\Admin\Controllers\HomeController*/
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}