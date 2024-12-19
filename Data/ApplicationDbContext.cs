using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _23210202037.Models;

namespace _23210202037.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // İlişkileri tanımlama
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionId);

            modelBuilder.Entity<City>()
                .HasOne(c => c.Country)
                .WithMany(cn => cn.Cities)
                .HasForeignKey(c => c.CountryId);

            modelBuilder.Entity<District>()
                .HasOne(d => d.City)
                .WithMany(c => c.Districts)
                .HasForeignKey(d => d.CityId);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.User)
                .WithMany(u => u.Images)
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<Slider>()
                .HasOne(s => s.Image)
                .WithMany(i => i.Sliders)
                .HasForeignKey(s => s.ImageId);

            modelBuilder.Entity<UserProfile>()
                .HasOne(up => up.User)
                .WithOne(u => u.UserProfile)
                .HasForeignKey<UserProfile>(up => up.UserId);

            modelBuilder.Entity<ActivityLog>()
                .HasOne(al => al.User)
                .WithMany(u => u.ActivityLogs)
                .HasForeignKey(al => al.UserId);

            modelBuilder.Entity<ImageTag>()
                .HasKey(it => new { it.ImageId, it.TagId });

            modelBuilder.Entity<ImageTag>()
                .HasOne(it => it.Image)
                .WithMany(i => i.ImageTags)
                .HasForeignKey(it => it.ImageId);

            modelBuilder.Entity<ImageTag>()
                .HasOne(it => it.Tag)
                .WithMany(t => t.ImageTags)
                .HasForeignKey(it => it.TagId);

            modelBuilder.Entity<Tag>()
                .HasMany(t => t.ImageTags)
                .WithOne(it => it.Tag)
                .HasForeignKey(it => it.TagId);
        }
    }
}