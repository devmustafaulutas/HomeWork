using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;

namespace _23210202037.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Soyad")]
        public string Surname { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "E-posta")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        [Display(Name = "Şifreyi Onayla")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = string.Empty;

        public IList<AuthenticationScheme> ExternalLogins { get; set; } = new List<AuthenticationScheme>();
    }
}