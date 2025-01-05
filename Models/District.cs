namespace _23210202037.Models
{
    using System.ComponentModel.DataAnnotations;

    public class District
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int Population { get; set; } = 0;

        public string Img { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int CityId { get; set; }
        public City City { get; set; } = null!;
    }
}