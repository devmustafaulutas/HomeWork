using Microsoft.AspNetCore.Identity;

namespace _23210202037.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; } = string.Empty;
        
        // Şifre alanını kaldırın
        // public string Password { get; set; } = string.Empty;
    }
}