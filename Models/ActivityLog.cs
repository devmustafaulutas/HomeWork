using System;

namespace _23210202037.Models
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Activity { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;

        // Navigation property
        public virtual User User { get; set; }
    }
}