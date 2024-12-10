using Microsoft.AspNetCore.Identity;
using _23210202037.Models;
using System.Threading.Tasks;

namespace _23210202037.Data
{
    public static class SeedData
    {
        public static async Task Initialize(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            // Rolleri ekleyin
            string[] roleNames = { "Admin", "User" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Admin kullanıcısını ekleyin
            var adminEmail = "admin@example.com";
            var adminUser = new User
            {
                UserName = adminEmail,
                Email = adminEmail,
                Name = "Admin",
                Surname = "User"
            };

            var user = await userManager.FindByEmailAsync(adminEmail);
            if (user == null)
            {
                var result = await userManager.CreateAsync(adminUser, "Admin123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}