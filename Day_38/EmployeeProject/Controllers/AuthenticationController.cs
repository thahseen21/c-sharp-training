using System.Threading.Tasks;
using EmployeeProject.Data;
using EmployeeProject.Models.Implementation;
using EmployeeProject.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ApplicationDbContext _db;

        private readonly UserManager<User> _userManager;

        public AuthenticationController(
            ApplicationDbContext db,
            UserManager<User> userManager
        )
        {
            this._db = db;
            this._userManager = userManager;
        }

        public async Task<IActionResult>
        Register([FromBody] RegisterViewModel data)
        {
            if (ModelState.IsValid)
            {
                var user =
                    new User()
                    {
                        UserName = data.Name,
                        Email = data.Email,
                        EmailConfirmed = true
                    };
                var userObj = await _userManager.FindByEmailAsync(data.Email);

                if (userObj == null)
                {
                    var result =
                        await _userManager.CreateAsync(user, data.Password);
                    if (result.Succeeded)
                    {
                        // return RedirectToAction("Index", "Home");
                        return Ok("successfully created");
                    }

                    // foreach (var error in result.Errors)
                    // {
                    //     ModelState.AddModelError("", error.Description);
                    // }
                }
            }
            return Ok();
        }
    }
}
