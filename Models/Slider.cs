namespace _23210202037.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ImageId { get; set; }
        public Image Image { get; set; } = new Image();
    }
}