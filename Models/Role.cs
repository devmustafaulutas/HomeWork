using Microsoft.AspNetCore.Identity;

namespace _23210202037.Models
{
    public class Role : IdentityRole<string>
    {
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}