using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using _23210202037.Models; // Bu satır mevcut

namespace _23210202037.Areas.Identity.Pages.Account
{
    public class AccountModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountModel(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [BindProperty]
        public LoginInputModel LoginInput { get; set; } = new LoginInputModel(); // Varsayılan değer atandı

        [BindProperty]
        public RegisterInputModel RegisterInput { get; set; } = new RegisterInputModel(); // Varsayılan değer atandı

        public string ReturnUrl { get; set; } = string.Empty; // Varsayılan değer atandı

        public class LoginInputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public class RegisterInputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl ?? string.Empty;
        }

        public async Task<IActionResult> OnPostLoginAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(LoginInput.Email, LoginInput.Password, LoginInput.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = LoginInput.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnPostRegisterAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new User { UserName = RegisterInput.Email, Email = RegisterInput.Email };
                var result = await _userManager.CreateAsync(user, RegisterInput.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }
    }
}

namespace _23210202037.Models
{
    // 'AnotherType' sınıfını dışa taşıdık
    public class AnotherType
    {
        // Gerekli özellikleri buraya ekleyin
    }

    public class UserAccountModel // Adı değiştirildi
    {
        [Required]
        public string Email { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı

        [Required]
        public string Password { get; set; } = string.Empty; // Nullable kaldırıldı ve varsayılan değer atandı

        public string? SomeProperty { get; set; } // Nullable hale getirildi
        public AnotherType AnotherProperty { get; set; } = new AnotherType(); // Varsayılan değer atandı
    }
}