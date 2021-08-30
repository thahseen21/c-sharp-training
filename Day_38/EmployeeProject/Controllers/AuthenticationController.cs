using System.Security.Claims;
using System.Threading.Tasks;
using EmployeeProject.Data;
using EmployeeProject.Models.Implementation;
using EmployeeProject.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthenticationController(
            ApplicationDbContext db,
            UserManager<User> userManager,
            SignInManager<User> signInManager
        )
        {
            this._db = db;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<IActionResult> Register([FromBody] RegisterViewModel data)
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

        [HttpGet("Login")]
        public IActionResult Login()
        {
            // return Ok("poitato");
            return View();
        }
        
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] LoginViewModel data)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(data.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, data.Password, false, false);
                    // return Ok("found user"+result);
                    if (result.Succeeded)
                    {
                        // return Ok("success");
                        var claims = new[] { new Claim(ClaimTypes.Name, data.UserName) };

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        await HttpContext.SignInAsync(
                                                 CookieAuthenticationDefaults.AuthenticationScheme,
                                                 new ClaimsPrincipal(identity),
                                                 new AuthenticationProperties
                                                 {
                                                     IsPersistent = false   //remember me
                                                 });

                        return Ok("successfully logged in");
                    }
                }
            }
            return Ok("some error");
        }
    }
}
