namespace _23210202037.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public ICollection<Slider> Sliders { get; set; } = new List<Slider>();
        public ICollection<ImageTag> ImageTags { get; set; } = new List<ImageTag>();
    }
}