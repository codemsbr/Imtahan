using Imtahan.Models;
using Imtahan.Role;
using Imtahan.ViewModels.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Imtahan.Controllers
{
    public class AuthController : Controller
    {
        UserManager<AppUser> _um { get; }
        SignInManager<AppUser> _sm { get; }
        //IdentityRole _ir { get; }
        public AuthController(UserManager<AppUser> um, SignInManager<AppUser> sm)
        {
            _um = um;
            _sm = sm;
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm register)
        {
            if(!ModelState.IsValid) 
            {
                return View(register);
            }
            AppUser user = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.UserName,
            };
            var result = await _um.CreateAsync(user,register.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(" ",error.Description);
                    return View(register);
                }
            }
            //Sifre => Salam!123
            //var roleResult = await _um.AddToRoleAsync(user,Roles.Admin.ToString());
            var roleResult = await _um.AddToRoleAsync(user, Roles.Member.ToString());
            if (!roleResult.Succeeded)
            {
                ModelState.AddModelError(" "," ");
                return View(roleResult);
            }
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVm register)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError(" ", "Passwor or UserName Wrong");
                return View(register);
            }

            AppUser user = register.UserNameorEmail switch
            {
                var item when item.Contains("@") => await _um.FindByEmailAsync(item),
                _ => await _um.FindByNameAsync(register.UserNameorEmail)
            };

            if(user == null)
            {
                ModelState.AddModelError(" ", "Passwor or UserName Wrong");
                return View(register);
            }

            var result = await _sm.PasswordSignInAsync(user,register.Password,register.IsRemember,true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(" ", "Passwor or UserName Wrong");
                return View(register);
            }
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _sm.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}
