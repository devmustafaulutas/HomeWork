namespace _23210202037.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public ICollection<Slider> Sliders { get; set; }
        public ICollection<ImageTag> ImageTags { get; set; }
    }
}