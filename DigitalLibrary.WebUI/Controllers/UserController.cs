using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DigitalLibrary.WebUI.Models;

namespace DigitalLibrary.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        public async Task<IActionResult> Details(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var roles = await _userManager.GetRolesAsync(user);
            var model = new UserDetailsViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Roles = roles.ToList()
            };
            return View(model);
        }
    }
}
