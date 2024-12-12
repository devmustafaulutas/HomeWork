using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _23210202037.Models;

public class ApplicationDbContext : IdentityDbContext<User, Role, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Tabloların isimlerini ayarlayın
        modelBuilder.Entity<User>(b =>
        {
            b.ToTable("users");
            b.Property(u => u.Id)
                .HasColumnType("int")
                .UseMySqlIdentityColumn(); // Otomatik artan kimlik sütunu
        });

        modelBuilder.Entity<Role>(b =>
        {
            b.ToTable("roles");
            b.Property(r => r.Id)
                .HasColumnType("int")
                .UseMySqlIdentityColumn(); // Otomatik artan kimlik sütunu
        });

        // Diğer yapılandırmalarınızı buraya ekleyin
    }
}