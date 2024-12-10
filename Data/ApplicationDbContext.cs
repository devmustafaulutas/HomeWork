using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _23210202037.Models;
using Microsoft.AspNetCore.Identity;

namespace _23210202037.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tabloların yeniden oluşturulmasını önlemek için gerekli yapılandırmaları yapın
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<IdentityRole>().ToTable("roles");
        }
    }
}