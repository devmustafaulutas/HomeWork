using System;

namespace _23210202037.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public string Activity { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User User { get; set; } = new User();
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}