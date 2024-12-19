using Microsoft.AspNetCore.Identity;

namespace _23210202037.Models
{
    public class User : IdentityUser<string>
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public ICollection<Image> Images { get; set; } = new List<Image>();
        public UserProfile UserProfile { get; set; } = null!;
        public ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();
    }
}