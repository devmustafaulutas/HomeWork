using System.ComponentModel.DataAnnotations;

namespace _23210202037.Models
{
    public class UserProfile
    {
        [Key]
        public int? UserId { get; set; } // Nullable yapıldı
        
        public string FirstName { get; set; } = null!;
        
        public string LastName { get; set; } = null!;
        
        public string? PhoneNumber { get; set; } // Nullable yapıldı
        
        public string? Address { get; set; } // Nullable yapıldı
        
        public virtual User User { get; set; } = null!;
    }
}