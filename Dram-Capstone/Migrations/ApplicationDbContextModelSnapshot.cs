﻿// <auto-generated />
using System;
using Dram_Capstone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dram_Capstone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dram_Capstone.Models.FragrantFlavor", b =>
                {
                    b.Property<int>("FragrantFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("FragrantFlavorId");

                    b.ToTable("FragrantFlavor");

                    b.HasData(
                        new
                        {
                            FragrantFlavorId = 1,
                            Name = "Lavender"
                        },
                        new
                        {
                            FragrantFlavorId = 2,
                            Name = "Acetone"
                        },
                        new
                        {
                            FragrantFlavorId = 3,
                            Name = "Pine"
                        },
                        new
                        {
                            FragrantFlavorId = 4,
                            Name = "Honey"
                        },
                        new
                        {
                            FragrantFlavorId = 5,
                            Name = "Beeswax"
                        },
                        new
                        {
                            FragrantFlavorId = 6,
                            Name = "Rose"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.FruityFlavor", b =>
                {
                    b.Property<int>("FruityFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("FruityFlavorId");

                    b.ToTable("FruityFlavor");

                    b.HasData(
                        new
                        {
                            FruityFlavorId = 1,
                            Name = "Apple"
                        },
                        new
                        {
                            FruityFlavorId = 2,
                            Name = "Fig"
                        },
                        new
                        {
                            FruityFlavorId = 3,
                            Name = "Cherry"
                        },
                        new
                        {
                            FruityFlavorId = 4,
                            Name = "Orange"
                        },
                        new
                        {
                            FruityFlavorId = 5,
                            Name = "Marmalade"
                        },
                        new
                        {
                            FruityFlavorId = 6,
                            Name = "Canned Peaches"
                        },
                        new
                        {
                            FruityFlavorId = 7,
                            Name = "Raisins"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.GrainyFlavor", b =>
                {
                    b.Property<int>("GrainyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GrainyFlavorId");

                    b.ToTable("GrainyFlavor");

                    b.HasData(
                        new
                        {
                            GrainyFlavorId = 1,
                            Name = "Coffee"
                        },
                        new
                        {
                            GrainyFlavorId = 2,
                            Name = "Dried Hops"
                        },
                        new
                        {
                            GrainyFlavorId = 3,
                            Name = "Malted Milk"
                        },
                        new
                        {
                            GrainyFlavorId = 4,
                            Name = "Breakfast Cereal"
                        },
                        new
                        {
                            GrainyFlavorId = 5,
                            Name = "Biscuits"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.GrassyFlavor", b =>
                {
                    b.Property<int>("GrassyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GrassyFlavorId");

                    b.ToTable("GrassyFlavor");

                    b.HasData(
                        new
                        {
                            GrassyFlavorId = 1,
                            Name = "Cut Grass"
                        },
                        new
                        {
                            GrassyFlavorId = 2,
                            Name = "Green Sticks"
                        },
                        new
                        {
                            GrassyFlavorId = 3,
                            Name = "Tobacco"
                        },
                        new
                        {
                            GrassyFlavorId = 4,
                            Name = "Dried Herbs"
                        },
                        new
                        {
                            GrassyFlavorId = 5,
                            Name = "Dried Tea Leaf"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.OffNoteFlavor", b =>
                {
                    b.Property<int>("OffNoteFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("OffNoteFlavorId");

                    b.ToTable("OffNoteFlavor");

                    b.HasData(
                        new
                        {
                            OffNoteFlavorId = 1,
                            Name = "Earthy"
                        },
                        new
                        {
                            OffNoteFlavorId = 2,
                            Name = "Roast Meat"
                        },
                        new
                        {
                            OffNoteFlavorId = 3,
                            Name = "Fatty"
                        },
                        new
                        {
                            OffNoteFlavorId = 4,
                            Name = "Leather"
                        },
                        new
                        {
                            OffNoteFlavorId = 5,
                            Name = "Struck Matches"
                        },
                        new
                        {
                            OffNoteFlavorId = 6,
                            Name = "Rusty"
                        },
                        new
                        {
                            OffNoteFlavorId = 7,
                            Name = "Vinegar"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.PeatyFlavor", b =>
                {
                    b.Property<int>("PeatyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("PeatyFlavorId");

                    b.ToTable("PeatyFlavor");

                    b.HasData(
                        new
                        {
                            PeatyFlavorId = 1,
                            Name = "Shellfish"
                        },
                        new
                        {
                            PeatyFlavorId = 2,
                            Name = "Brine"
                        },
                        new
                        {
                            PeatyFlavorId = 3,
                            Name = "Seaweed"
                        },
                        new
                        {
                            PeatyFlavorId = 4,
                            Name = "Iodine"
                        },
                        new
                        {
                            PeatyFlavorId = 5,
                            Name = "Mouthwash"
                        },
                        new
                        {
                            PeatyFlavorId = 6,
                            Name = "Peat Smoke"
                        },
                        new
                        {
                            PeatyFlavorId = 7,
                            Name = "Smoked Salmon"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("FragrantFlavor_Id");

                    b.Property<int>("FruityFlavor_Id");

                    b.Property<int>("GrainyFlavor_Id");

                    b.Property<int>("GrassyFlavor_Id");

                    b.Property<int>("OffNotesFlavor_Id");

                    b.Property<int>("PeatyFlavor_Id");

                    b.Property<int>("ReviewScore");

                    b.Property<string>("TastingNotes");

                    b.Property<int?>("WhiskeyId");

                    b.Property<int>("WineyFlavor_Id");

                    b.Property<int>("WoodyFlavor_Id");

                    b.HasKey("ReviewId");

                    b.HasIndex("WhiskeyId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FragrantFlavor_Id = 1,
                            FruityFlavor_Id = 1,
                            GrainyFlavor_Id = 1,
                            GrassyFlavor_Id = 1,
                            OffNotesFlavor_Id = 1,
                            PeatyFlavor_Id = 1,
                            ReviewScore = 95,
                            TastingNotes = "lots of alcohol, very smokey, good neat",
                            WineyFlavor_Id = 1,
                            WoodyFlavor_Id = 1
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.Whiskey", b =>
                {
                    b.Property<int>("WhiskeyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Distillery")
                        .IsRequired();

                    b.Property<bool>("Favorite");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("User_Id")
                        .IsRequired();

                    b.Property<int?>("WhiskeyReview_Id");

                    b.HasKey("WhiskeyId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Whiskey");

                    b.HasData(
                        new
                        {
                            WhiskeyId = 1,
                            Distillery = "Ardbeg",
                            Favorite = false,
                            Name = "10 year",
                            User_Id = "f17ffaee-4be6-4626-827d-cfad97ac21fd",
                            WhiskeyReview_Id = 1
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.WineyFlavor", b =>
                {
                    b.Property<int>("WineyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("WineyFlavorId");

                    b.ToTable("WineyFlavor");

                    b.HasData(
                        new
                        {
                            WineyFlavorId = 1,
                            Name = "Almond"
                        },
                        new
                        {
                            WineyFlavorId = 2,
                            Name = "Cream"
                        },
                        new
                        {
                            WineyFlavorId = 3,
                            Name = "Butter"
                        },
                        new
                        {
                            WineyFlavorId = 4,
                            Name = "Chocolate"
                        },
                        new
                        {
                            WineyFlavorId = 5,
                            Name = "Olive"
                        },
                        new
                        {
                            WineyFlavorId = 6,
                            Name = "Sherry"
                        },
                        new
                        {
                            WineyFlavorId = 7,
                            Name = "Port"
                        },
                        new
                        {
                            WineyFlavorId = 8,
                            Name = "Red Wine"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.WoodyFlavor", b =>
                {
                    b.Property<int>("WoodyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("WoodyFlavorId");

                    b.ToTable("WoodyFlavor");

                    b.HasData(
                        new
                        {
                            WoodyFlavorId = 1,
                            Name = "Caramel"
                        },
                        new
                        {
                            WoodyFlavorId = 2,
                            Name = "Creme Brulee"
                        },
                        new
                        {
                            WoodyFlavorId = 3,
                            Name = "Caramel"
                        },
                        new
                        {
                            WoodyFlavorId = 4,
                            Name = "Clove"
                        },
                        new
                        {
                            WoodyFlavorId = 5,
                            Name = "Pepper"
                        },
                        new
                        {
                            WoodyFlavorId = 6,
                            Name = "Cigar Box"
                        },
                        new
                        {
                            WoodyFlavorId = 7,
                            Name = "Ginger"
                        },
                        new
                        {
                            WoodyFlavorId = 8,
                            Name = "Liquorice"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Dram_Capstone.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "f17ffaee-4be6-4626-827d-cfad97ac21fd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "567148f4-a715-42e8-88fe-01973e08b01c",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKFRHJbHX8ibl+62D4/NRoP2oDJz1KmD50cMwMqcJgdD+KyFQ2LVL/4KQX/7Exo2nw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd1370d9-2e83-453a-8a36-d8cce0d19b05",
                            TwoFactorEnabled = false,
                            FirstName = "admin",
                            LastName = "admin"
                        });
                });

            modelBuilder.Entity("Dram_Capstone.Models.Review", b =>
                {
                    b.HasOne("Dram_Capstone.Models.Whiskey")
                        .WithMany("Reviews")
                        .HasForeignKey("WhiskeyId");
                });

            modelBuilder.Entity("Dram_Capstone.Models.Whiskey", b =>
                {
                    b.HasOne("Dram_Capstone.Models.ApplicationUser")
                        .WithMany("Whiskeys")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
