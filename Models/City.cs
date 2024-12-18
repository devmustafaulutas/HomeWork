namespace _23210202037.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;

        public ICollection<District> Districts { get; set; } = new List<District>();

        public ICollection<User> Users { get; set; } = new List<User>(); // 'Users' koleksiyonu eklendi
    }
}