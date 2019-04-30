using System;
using System.Collections.Generic;
using System.Text;
using Dram_Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dram_Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Whiskey> Whiskey { get; set; }
        public DbSet<FragrantFlavor> FragrantFlavor { get; set; }
        public DbSet<FruityFlavor> FruityFlavor { get; set; }
        public DbSet<GrainyFlavor> GrainyFlavor { get; set; }
        public DbSet<GrassyFlavor> GrassyFlavor { get; set; }
        public DbSet<OffNoteFlavor> OffNoteFlavor { get; set; }
        public DbSet<PeatyFlavor> PeatyFlavor { get; set; }
        public DbSet<WineyFlavor> WineyFlavor { get; set; }
        public DbSet<WoodyFlavor> WoodyFlavor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);
        }
    }
}
