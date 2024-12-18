namespace _23210202037.Models
{
    public class ImageTag
    {
        public int Id { get; set; }
        // public string Tag { get; set; } // Bu satırı kaldırın

        // ...existing code...

        public int ImageId { get; set; }
        public int TagId { get; set; }

        public Image Image { get; set; } = null!;
        public Tag Tag { get; set; } = null!; // Tipi 'Tag' olarak ayarlandı

        // ...existing code...
    }
}