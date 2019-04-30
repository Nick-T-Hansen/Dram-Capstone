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
                });

            modelBuilder.Entity("Dram_Capstone.Models.FruityFlavor", b =>
                {
                    b.Property<int>("FruityFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("FruityFlavorId");

                    b.ToTable("FruityFlavor");
                });

            modelBuilder.Entity("Dram_Capstone.Models.GrainyFlavor", b =>
                {
                    b.Property<int>("GrainyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GrainyFlavorId");

                    b.ToTable("GrainyFlavor");
                });

            modelBuilder.Entity("Dram_Capstone.Models.GrassyFlavor", b =>
                {
                    b.Property<int>("GrassyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GrassyFlavorId");

                    b.ToTable("GrassyFlavor");
                });

            modelBuilder.Entity("Dram_Capstone.Models.OffNoteFlavor", b =>
                {
                    b.Property<int>("OffNoteFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("OffNoteFlavorId");

                    b.ToTable("OffNoteFlavor");
                });

            modelBuilder.Entity("Dram_Capstone.Models.PeatyFlavor", b =>
                {
                    b.Property<int>("PeatyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("PeatyFlavorId");

                    b.ToTable("PeatyFlavor");
                });

            modelBuilder.Entity("Dram_Capstone.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Distillery")
                        .IsRequired();

                    b.Property<bool>("Favorite");

                    b.Property<int>("FragrantFlavor_Id");

                    b.Property<int>("FruityFlavor_Id");

                    b.Property<int>("GrainyFlavor_Id");

                    b.Property<int>("GrassyFlavor_Id");

                    b.Property<int>("OffNotesFlavor_Id");

                    b.Property<int>("PeatyFlavor_Id");

                    b.Property<int>("ReviewScore");

                    b.Property<string>("User_Id")
                        .IsRequired();

                    b.Property<int?>("WhiskeyId");

                    b.Property<int>("WhiskeyReview_Id");

                    b.Property<int>("WineyFlavor_Id");

                    b.Property<int>("WoodyFlavor_Id");

                    b.HasKey("ReviewId");

                    b.HasIndex("WhiskeyId");

                    b.ToTable("Review");
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

                    b.Property<int>("WhiskeyReview_Id");

                    b.HasKey("WhiskeyId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Whiskey");
                });

            modelBuilder.Entity("Dram_Capstone.Models.WineyFlavor", b =>
                {
                    b.Property<int>("WineyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("WineyFlavorId");

                    b.ToTable("WineyFlavor");
                });

            modelBuilder.Entity("Dram_Capstone.Models.WoodyFlavor", b =>
                {
                    b.Property<int>("WoodyFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("WoodyFlavorId");

                    b.ToTable("WoodyFlavor");
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
                            Id = "cd87d503-d35c-465e-9f7c-3d2a4519203e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ba85921-006e-4855-9583-c94d7f22fd30",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBjxI4gQDbxmRkBPcqm9wN9fiEY/6h6f2gUxdtLG0ntBcrfH5lLBDZtXmrV+OCFSHg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2806245c-0924-41d1-abc9-b6b7902c9165",
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
