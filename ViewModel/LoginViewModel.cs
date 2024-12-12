using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;

namespace _23210202037.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-posta")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; } = string.Empty;

        public IList<AuthenticationScheme> ExternalLogins { get; set; } = new List<AuthenticationScheme>();
    }
}