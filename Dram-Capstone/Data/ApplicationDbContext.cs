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

            // this is ensuring that the Donation that was created when the DB was built, gets the current Date
            modelBuilder.Entity<Review>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");
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
                    Review_Id = 1
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    
                    Review_Id = 1,
                    TastingNotes = "lots of alcohol, very smokey, good neat",
                    ReviewScore = 95,
                    WoodyFlavor_Id = 1,
                    FragrantFlavor_Id = 1,
                    FruityFlavor_Id = 1,
                    GrainyFlavor_Id = 1,
                    GrassyFlavor_Id = 1,
                    OffNoteFlavor_Id = 1,
                    PeatyFlavor_Id = 1,
                    WineyFlavor_Id = 1
                }
            );


            modelBuilder.Entity<FragrantFlavor>().HasData(
                new FragrantFlavor()
                {
                    FragrantFlavor_Id = 1,
                    Name = "Lavender"
                },
                new FragrantFlavor()
                {
                    FragrantFlavor_Id = 2,
                    Name = "Acetone"
                },
                new FragrantFlavor()
                {
                    FragrantFlavor_Id = 3,
                    Name = "Pine"
                },

                new FragrantFlavor()
                {
                    FragrantFlavor_Id = 4,
                    Name = "Honey"
                },

                new FragrantFlavor()
                {
                    FragrantFlavor_Id = 5,
                    Name = "Beeswax"
                },
                new FragrantFlavor()
                {
                    FragrantFlavor_Id = 6,
                    Name = "Rose"
                }

            );
            modelBuilder.Entity<FruityFlavor>().HasData(
                new FruityFlavor()
                {
                    FruityFlavor_Id = 1,
                    Name = "Apple"
                },

                new FruityFlavor()
                {
                    FruityFlavor_Id = 2,
                    Name = "Fig"
                },

                new FruityFlavor()
                {
                    FruityFlavor_Id = 3,
                    Name = "Cherry"
                },

                new FruityFlavor()
                {
                    FruityFlavor_Id = 4,
                    Name = "Orange"
                },

                new FruityFlavor()
                {
                    FruityFlavor_Id = 5,
                    Name = "Marmalade"
                },

                new FruityFlavor()
                {
                    FruityFlavor_Id = 6,
                    Name = "Canned Peaches"
                },

                new FruityFlavor()
                {
                    FruityFlavor_Id = 7,
                    Name = "Raisins"
                }
            );

            modelBuilder.Entity<GrainyFlavor>().HasData(
                new GrainyFlavor()
                {
                    GrainyFlavor_Id = 1,
                    Name = "Coffee"
                },
                new GrainyFlavor()
                {
                    GrainyFlavor_Id = 2,
                    Name = "Dried Hops"
                },
                new GrainyFlavor()
                {
                    GrainyFlavor_Id = 3,
                    Name = "Malted Milk"
                },
                new GrainyFlavor()
                {
                    GrainyFlavor_Id = 4,
                    Name = "Breakfast Cereal"
                },
                new GrainyFlavor()
                {
                    GrainyFlavor_Id = 5,
                    Name = "Biscuits"
                }
            );

            modelBuilder.Entity<GrassyFlavor>().HasData(
               new GrassyFlavor()
               {
                   GrassyFlavor_Id = 1,
                   Name = "Cut Grass"
               },
               new GrassyFlavor()
               {
                   GrassyFlavor_Id = 2,
                   Name = "Green Sticks"
               },
               new GrassyFlavor()
               {
                   GrassyFlavor_Id = 3,
                   Name = "Tobacco"
               },
               new GrassyFlavor()
               {
                   GrassyFlavor_Id = 4,
                   Name = "Dried Herbs"
               },
               new GrassyFlavor()
               {
                   GrassyFlavor_Id = 5,
                   Name = "Dried Tea Leaf"
               }
           );

            modelBuilder.Entity<OffNoteFlavor>().HasData(
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 1,
                   Name = "Earthy",
               },
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 2,
                   Name = "Roast Meat",
               },
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 3,
                   Name = "Fatty",
               },
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 4,
                   Name = "Leather",
               },
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 5,
                   Name = "Struck Matches",
               },
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 6,
                   Name = "Rusty",
               },
               new OffNoteFlavor()
               {
                   OffNoteFlavor_Id = 7,
                   Name = "Vinegar",
               }
             
           );

            modelBuilder.Entity<PeatyFlavor>().HasData(
               new PeatyFlavor()
               {
                   PeatyFlavor_Id = 1,
                   Name = "Shellfish"
               },
                new PeatyFlavor()
                {
                    PeatyFlavor_Id = 2,
                    Name = "Brine"
                },
                new PeatyFlavor()
                {
                    PeatyFlavor_Id = 3,
                    Name = "Seaweed"
                },
                new PeatyFlavor()
                {
                    PeatyFlavor_Id = 4,
                    Name = "Iodine"
                },
                new PeatyFlavor()
                {
                    PeatyFlavor_Id = 5,
                    Name = "Mouthwash"
                },
                new PeatyFlavor()
                {
                    PeatyFlavor_Id = 6,
                    Name = "Peat Smoke"
                },
                new PeatyFlavor()
                {
                    PeatyFlavor_Id = 7,
                    Name = "Smoked Salmon"
                }
           );

            modelBuilder.Entity<WineyFlavor>().HasData(
                new WineyFlavor()
                {
                    WineyFlavor_Id = 1,
                    Name = "Almond"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 2,
                    Name = "Cream"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 3,
                    Name = "Butter"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 4,
                    Name = "Chocolate"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 5,
                    Name = "Olive"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 6,
                    Name = "Sherry"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 7,
                    Name = "Port"
                },
                new WineyFlavor()
                {
                    WineyFlavor_Id = 8,
                    Name = "Red Wine"
                }

           );

            modelBuilder.Entity<WoodyFlavor>().HasData(
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 1,
                   Name = "Caramel"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 2,
                   Name = "Creme Brulee"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 3,
                   Name = "Syrup"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 4,
                   Name = "Clove"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 5,
                   Name = "Pepper"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 6,
                   Name = "Cigar Box"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 7,
                   Name = "Ginger"
               },
               new WoodyFlavor()
               {
                   WoodyFlavor_Id = 8,
                   Name = "Liquorice"
               }
           );
           
        }
    }
}

