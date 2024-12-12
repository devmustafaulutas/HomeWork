using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using _23210202037.Models;
using _23210202037.ViewModels;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace _23210202037.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Login")]
        public IActionResult Login(string returnUrl = null!)
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        return Redirect(model.ReturnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Geçersiz Giriş Denemesi.");
                }
            }

            // Hata durumunda sayfayı tekrar göster
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync())?.ToList() ?? new List<AuthenticationScheme>();
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Register")]
        public IActionResult Register(string returnUrl = null!)
        {
            var model = new RegisterViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // İstenirse kullanıcı rolü ekleyin
                    await _signInManager.SignInAsync(user, isPersistent: false);
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

            // Hata durumunda sayfayı tekrar göster
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync())?.ToList() ?? new List<AuthenticationScheme>();
            return View(model);
        }

        // Diğer metotlar (Logout vb.) burada yer alır...
    }
}