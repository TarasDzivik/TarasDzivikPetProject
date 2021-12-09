using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using TarasDzivikPetProject.Models;

namespace TarasDzivikPetProject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        /* Тут ми очікуємо нашу модель (так званий зв'язуватель моделі в фреймворку ASP.NET.Core)
        В пост запиті, при натисканні кнопки ввійти у нас знову відбудеться зв'язування моделі
        і ми будемо працювати з об'єктом класу "ViewModel" */ 
        public async Task<IActionResult> Login(LoginViewModel model,string returnUrl) 
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false); 
                    // Останній флажок False - це заблокувати користувача після кількох невдалих спроб входу ^ (true для активації)
                    if (result.Succeeded)
                    {
                        /* Відправляємо користувача на ту ж сторінку з якої він намагався авторизуватись,
                         в іншому ("??") випадку повертаємо його на головну сторінку "/" */
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Невірний логін чи пароль!");
            }
            return View(model);
        }
        [Authorize] // Можливість вилогінитись адміністратору в цілях безпеки
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}