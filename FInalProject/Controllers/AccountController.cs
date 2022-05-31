using System.Threading.Tasks;
using FInalProject.Data;
using FInalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }


        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }

            return View(model);
        }

        public IActionResult RegisterClient()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterClient(RegisterClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                //TODO
                IdentityUser user = new IdentityUser {Email = client.Email, UserName = client.Email};
                // добавляем пользователя


                var result = await _userManager.CreateAsync(user, client.Password);
                if (result.Succeeded)
                {
                    //add role our user
                    await _userManager.AddToRoleAsync(user, Roles.Client.ToString());
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(client);
        }

        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAdmin(RegisterAdminViewModel admin)
        {
            if (ModelState.IsValid)
            {
                //TODO
                IdentityUser user = new IdentityUser {Email = admin.Email, UserName = admin.Email};
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, admin.Password);
                if (result.Succeeded)
                {
                    //add role our user
                    await _userManager.AddToRoleAsync(user, Roles.Admin.ToString());
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(admin);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}