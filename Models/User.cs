using Microsoft.AspNetCore.Identity;

namespace _23210202037.Models
{
    public class User : IdentityUser<string> // Doğru miras alındı
    {
        public string Name { get; set; } = string.Empty; // Varsayılan değer atandı
        public string Surname { get; set; } = string.Empty; // Varsayılan değer atandı
        public string RoleId { get; set; } = string.Empty; // Varsayılan değer atandı
        public Role Role { get; set; } = null!; // Null ataması kaldırıldı
        public int CityId { get; set; }
        public City City { get; set; } = null!; // Null ataması kaldırıldı
        public ICollection<Image> Images { get; set; } = new List<Image>(); // Koleksiyon başlatıldı
        public UserProfile UserProfile { get; set; } = null!; // Null ataması kaldırıldı
        public ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>(); // Koleksiyon başlatıldı
    }
}