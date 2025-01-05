using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _23210202037.Models;

namespace _23210202037.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<District> Districts { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ASP.NET Identity tablolarının isimlerini değiştirme
            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.ToTable("users");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("roles");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("user_roles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("user_claims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("user_logins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("role_claims");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("user_tokens");
            });

            // Diğer tabloların isimlerini ayarlayın
            modelBuilder.Entity<Country>(b =>
            {
                b.ToTable("countries");
            });

            modelBuilder.Entity<City>(b =>
            {
                b.ToTable("cities");
            });

            modelBuilder.Entity<District>(b =>
            {
                b.ToTable("districts");
            });

            modelBuilder.Entity<Image>(b =>
            {
                b.ToTable("images");
            });

            // İlişkileri tanımlama
            modelBuilder.Entity<City>()
                .HasOne(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryId);

            modelBuilder.Entity<District>()
                .HasOne(d => d.City)
                .WithMany(c => c.Districts)
                .HasForeignKey(d => d.CityId);


        }
    }
}