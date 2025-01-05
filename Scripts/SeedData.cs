using Microsoft.AspNetCore.Identity;
using _23210202037.Models;
using System.Threading.Tasks;

namespace _23210202037.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(RoleManager<IdentityRole> roleManager, UserManager<User> userManager) // Metod adı değiştirildi
        {
            string[] roles = { "Admin", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
                }
            }

            var adminUser = new User
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                FullName = "Admin"
                // Password özelliğini kaldırdık, şifreyi burada ayarlayacağız
            };

            if (await userManager.FindByEmailAsync(adminUser.Email) == null)
            {
                var result = await userManager.CreateAsync(adminUser, "Admin@123"); // Şifre burada belirlenir

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
        }
    }
}