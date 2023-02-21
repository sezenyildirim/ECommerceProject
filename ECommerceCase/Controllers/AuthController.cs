using ECommerce.Entity.DTOS;
using ECommerce.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCase.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            AppUser user = await _userManager.FindByEmailAsync(loginDTO.UserName);
            if(user == null)
            {
                user = await _userManager.FindByNameAsync(loginDTO.UserName);
            }
            if(user == null)
            {
                TempData["errors"] = "User not found!";
                return RedirectToAction("Index", "Auth");
            }

            bool result = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (result)
            {
                var roles = await _userManager.GetRolesAsync(user);
                TempData["roles"] = roles;
                return RedirectToAction("Index", "Home");
            }

            TempData["errors"] = "Password is wrong!";
            return RedirectToAction("Index", "Auth");
        }
    }
}
