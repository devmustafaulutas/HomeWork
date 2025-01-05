using Microsoft.AspNetCore.Identity;
using _23210202037.Models;
using System.Threading.Tasks;

namespace _23210202037.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            string[] roles = { "Admin", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
                }
            }

            var hasher = new PasswordHasher<User>();

            var adminUser = new User
            {
                Id = "1",
                UserName = "admin",
                Email = "admin@example.com",
                FullName = "Admin",
                PasswordHash = hasher.HashPassword(null!, "Admin@123"),
                EmailConfirmed = true
            };

            if (await userManager.FindByEmailAsync(adminUser.Email) == null)
            {
                var result = await userManager.CreateAsync(adminUser, "Admin@123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
                else
                {
                    // Hata yönetimi eklendi
                    foreach (var error in result.Errors)
                    {
                        // Örneğin loglayabilirsiniz
                        Console.WriteLine($"Error creating admin user: {error.Description}");
                    }
                }
            }

            var defaultUser = new User
            {
                Id = "2",
                UserName = "user",
                Email = "user@example.com",
                FullName = "Default User",
                PasswordHash = hasher.HashPassword(null!, "User@123"),
                EmailConfirmed = true
            };

            if (await userManager.FindByEmailAsync(defaultUser.Email) == null)
            {
                var result = await userManager.CreateAsync(defaultUser, "User@123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(defaultUser, "User");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error creating default user: {error.Description}");
                    }
                }
            }
        }
    }
}