namespace _23210202037.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        // Navigation property
        public virtual City City { get; set; }
    }
}