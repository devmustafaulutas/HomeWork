using Microsoft.AspNetCore.Identity;

namespace _23210202037.Models
{
    public class Role : IdentityRole
    {
        public string roles { get; set; } = string.Empty;
    }
}