using Microsoft.AspNetCore.Identity;
using _23210202037.Models;
using System.Threading.Tasks;

namespace _23210202037.Data
{
    public static class SeedData
    {
        public static async Task Initialize(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            string[] roles = { "Admin", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new Role { Name = role });
                }
            }

            var adminUser = new User
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                Name = "Admin",
                Surname = "User"
            };

            if (await userManager.FindByEmailAsync(adminUser.Email) == null)
            {
                var result = await userManager.CreateAsync(adminUser, "Admin@123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}

public class Role
{
    public string Name { get; set; }
    // ...existing code...
}

public class User
{
    public string UserName { get; set; } = string.Empty; // Varsayılan değer atandı
    public string Email { get; set; } = string.Empty; // Varsayılan değer atandı
    public string? Name { get; set; } = string.Empty; // Varsayılan değer atandı
    public string Surname { get; set; } = string.Empty; // Varsayılan değer atandı
    // ...existing code...
}