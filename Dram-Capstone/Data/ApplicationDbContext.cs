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

            modelBuilder.Entity<Whiskey>().HasData(
                new Whiskey()
                {
                    WhiskeyId = 1,
                    Distillery = "Ardbeg",
                    Name = "10 year",
                    User_Id = user.Id,
                    Favorite = false,
                    WhiskeyReview_Id = 1
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    DateCreated = DateTime.Now,
                    ReviewId = 1,
                    TastingNotes = "lots of alcohol, very smokey, good neat",
                    ReviewScore = 95,
                    WoodyFlavor_Id = 1,
                    FragrantFlavor_Id = 1,
                    FruityFlavor_Id = 1,
                    GrainyFlavor_Id = 1,
                    GrassyFlavor_Id = 1,
                    OffNotesFlavor_Id = 1,
                    PeatyFlavor_Id = 1,
                    WineyFlavor_Id = 1
                }
            );


            modelBuilder.Entity<FragrantFlavor>().HasData(
                new FragrantFlavor()
                {
                    FragrantFlavorId = 1,
                    Name = "Lavender"
                },

                new FragrantFlavor()
                {
                    FragrantFlavorId = 2,
                    Name = "Acetone"
                },

                new FragrantFlavor()
                {
                    FragrantFlavorId = 3,
                    Name = "Pine"
                },

                new FragrantFlavor()
                {
                    FragrantFlavorId = 4,
                    Name = "Honey"
                },

                new FragrantFlavor()
                {
                    FragrantFlavorId = 5,
                    Name = "Beeswax"
                },
                new FragrantFlavor()
                {
                    FragrantFlavorId = 6,
                    Name = "Rose"
                }

            );
            modelBuilder.Entity<FruityFlavor>().HasData(
                new FruityFlavor()
                {
                    FruityFlavorId = 1,
                    Name = "Apple"
                },

                new FruityFlavor()
                {
                    FruityFlavorId = 2,
                    Name = "Fig"
                },

                new FruityFlavor()
                {
                    FruityFlavorId = 3,
                    Name = "Cherry"
                },

                new FruityFlavor()
                {
                    FruityFlavorId = 4,
                    Name = "Orange"
                },

                new FruityFlavor()
                {
                    FruityFlavorId = 5,
                    Name = "Marmalade"
                },

                new FruityFlavor()
                {
                    FruityFlavorId = 6,
                    Name = "Canned Peaches"
                },

                new FruityFlavor()
                {
                    FruityFlavorId = 7,
                    Name = "Raisins"
                }
            );
        }
    }
}

