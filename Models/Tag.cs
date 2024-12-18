namespace _23210202037.Models
{
    public class Tag
    {
        public int Id { get; set; } // Nullable yapmanıza gerek yok
        public string TagName { get; set; } = string.Empty; // Varsayılan değer atandı
        public ICollection<ImageTag>? ImageTags { get; set; } // Yeni özellik eklendi
    }
}