namespace _23210202037.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ImageId { get; set; }

        public virtual Image Image { get; set; }
    }
}