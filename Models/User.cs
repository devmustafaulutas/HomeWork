using Microsoft.AspNetCore.Identity;

public class User : IdentityUser<int>
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    // Diğer özelleştirilmiş özellikler...
}