using Microsoft.AspNetCore.Identity;

namespace _23210202037.Models
{
    public class Role : IdentityRole<string> // Doğru miras alındı
    {
        // Özel özellikler ekleyebilirsiniz
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>(); // Koleksiyon başlatıldı

        // Yeni eklenen Users koleksiyonu
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}