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

            // Seed Data
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Türkiye" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Çanakkale", CountryId = 1 }
            );

            modelBuilder.Entity<District>().HasData(
                new District { Id = 1, Name = "Ayvacık", Population = 30000, Img = "ayvacik.jpeg", Description = "Ayvacık, tarihi ve doğal güzellikleriyle ünlüdür.", CityId = 1 },
                new District { Id = 2, Name = "Bayramiç", Population = 20000, Img = "bayramic.jpeg", Description = "Bayramiç, Kazdağları'nın eteklerinde yer alır.", CityId = 1 },
                new District { Id = 3, Name = "Biga", Population = 90000, Img = "biga.jpg", Description = "Biga, Çanakkale'nin en büyük ilçelerinden biridir.", CityId = 1 },
                new District { Id = 4, Name = "Bozcaada", Population = 2500, Img = "bozcaada.jpeg", Description = "Bozcaada, Türkiye'nin üçüncü büyük adasıdır.", CityId = 1 },
                new District { Id = 5, Name = "Çan", Population = 50000, Img = "can.jpeg", Description = "Çan, seramik ve çini üretimi ile ünlüdür.", CityId = 1 },
                new District { Id = 6, Name = "Eceabat", Population = 5000, Img = "eceabat.jpeg", Description = "Eceabat, Gelibolu Yarımadası'nda yer alır.", CityId = 1 },
                new District { Id = 7, Name = "Ezine", Population = 40000, Img = "ezine.jpeg", Description = "Ezine, peyniri ile ünlüdür.", CityId = 1 },
                new District { Id = 8, Name = "Gelibolu", Population = 45000, Img = "gelibolu.jpeg", Description = "Gelibolu, tarihi savaş alanları ile bilinir.", CityId = 1 },
                new District { Id = 9, Name = "Gökçeada", Population = 8000, Img = "gokceada.jpeg", Description = "Gökçeada, Türkiye'nin en büyük adasıdır.", CityId = 1 },
                new District { Id = 10, Name = "Lapseki", Population = 25000, Img = "lapseki.jpeg", Description = "Lapseki, kirazı ile ünlüdür.", CityId = 1 },
                new District { Id = 11, Name = "Yenice", Population = 15000, Img = "yenice.jpeg", Description = "Yenice, ormanları ve doğal güzellikleri ile bilinir.", CityId = 1 }
            );
        }
    }
}