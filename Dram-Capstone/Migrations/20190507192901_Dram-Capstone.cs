using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dram_Capstone.Migrations
{
    public partial class DramCapstone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FragrantFlavor",
                columns: table => new
                {
                    FragrantFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FragrantFlavor", x => x.FragrantFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "FruityFlavor",
                columns: table => new
                {
                    FruityFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruityFlavor", x => x.FruityFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "GrainyFlavor",
                columns: table => new
                {
                    GrainyFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrainyFlavor", x => x.GrainyFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "GrassyFlavor",
                columns: table => new
                {
                    GrassyFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrassyFlavor", x => x.GrassyFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "OffNoteFlavor",
                columns: table => new
                {
                    OffNoteFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffNoteFlavor", x => x.OffNoteFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "PeatyFlavor",
                columns: table => new
                {
                    PeatyFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeatyFlavor", x => x.PeatyFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "WineyFlavor",
                columns: table => new
                {
                    WineyFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineyFlavor", x => x.WineyFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "WoodyFlavor",
                columns: table => new
                {
                    WoodyFlavor_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodyFlavor", x => x.WoodyFlavor_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Review_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    TastingNotes = table.Column<string>(nullable: true),
                    ReviewScore = table.Column<int>(nullable: false),
                    WoodyFlavor_Id = table.Column<int>(nullable: false),
                    WineyFlavor_Id = table.Column<int>(nullable: false),
                    OffNoteFlavor_Id = table.Column<int>(nullable: false),
                    FruityFlavor_Id = table.Column<int>(nullable: false),
                    FragrantFlavor_Id = table.Column<int>(nullable: false),
                    PeatyFlavor_Id = table.Column<int>(nullable: false),
                    GrainyFlavor_Id = table.Column<int>(nullable: false),
                    GrassyFlavor_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Review_Id);
                    table.ForeignKey(
                        name: "FK_Review_FragrantFlavor_FragrantFlavor_Id",
                        column: x => x.FragrantFlavor_Id,
                        principalTable: "FragrantFlavor",
                        principalColumn: "FragrantFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_FruityFlavor_FruityFlavor_Id",
                        column: x => x.FruityFlavor_Id,
                        principalTable: "FruityFlavor",
                        principalColumn: "FruityFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_GrainyFlavor_GrainyFlavor_Id",
                        column: x => x.GrainyFlavor_Id,
                        principalTable: "GrainyFlavor",
                        principalColumn: "GrainyFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_GrassyFlavor_GrassyFlavor_Id",
                        column: x => x.GrassyFlavor_Id,
                        principalTable: "GrassyFlavor",
                        principalColumn: "GrassyFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_OffNoteFlavor_OffNoteFlavor_Id",
                        column: x => x.OffNoteFlavor_Id,
                        principalTable: "OffNoteFlavor",
                        principalColumn: "OffNoteFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_PeatyFlavor_PeatyFlavor_Id",
                        column: x => x.PeatyFlavor_Id,
                        principalTable: "PeatyFlavor",
                        principalColumn: "PeatyFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_WineyFlavor_WineyFlavor_Id",
                        column: x => x.WineyFlavor_Id,
                        principalTable: "WineyFlavor",
                        principalColumn: "WineyFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_WoodyFlavor_WoodyFlavor_Id",
                        column: x => x.WoodyFlavor_Id,
                        principalTable: "WoodyFlavor",
                        principalColumn: "WoodyFlavor_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Whiskey",
                columns: table => new
                {
                    WhiskeyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Distillery = table.Column<string>(nullable: false),
                    Review_Id = table.Column<int>(nullable: true),
                    User_Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Favorite = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whiskey", x => x.WhiskeyId);
                    table.ForeignKey(
                        name: "FK_Whiskey_Review_Review_Id",
                        column: x => x.Review_Id,
                        principalTable: "Review",
                        principalColumn: "Review_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Whiskey_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "85ee9ee5-ecbd-40d8-a31e-a5c20c59fa1c", 0, "61d85423-79ec-45c4-97b3-d739610e83cc", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", null, "AQAAAAEAACcQAAAAELkBC92YoaldxZrc4gjBDv/bEvmSiS9BLfSVJ7lyZZ7P39bHnBuNdP7/iH7nroWv+A==", null, false, "7e386b2a-b41b-4ab3-b26f-62b94f9cfd51", false, null, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "FragrantFlavor",
                columns: new[] { "FragrantFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lavender" },
                    { 2, "Acetone" },
                    { 3, "Pine" },
                    { 4, "Honey" },
                    { 5, "Beeswax" },
                    { 6, "Rose" }
                });

            migrationBuilder.InsertData(
                table: "FruityFlavor",
                columns: new[] { "FruityFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 6, "Canned Peaches" },
                    { 5, "Marmalade" },
                    { 4, "Orange" },
                    { 7, "Raisins" },
                    { 2, "Fig" },
                    { 1, "Apple" },
                    { 3, "Cherry" }
                });

            migrationBuilder.InsertData(
                table: "GrainyFlavor",
                columns: new[] { "GrainyFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 1, "Coffee" },
                    { 2, "Dried Hops" },
                    { 3, "Malted Milk" },
                    { 4, "Breakfast Cereal" },
                    { 5, "Biscuits" }
                });

            migrationBuilder.InsertData(
                table: "GrassyFlavor",
                columns: new[] { "GrassyFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cut Grass" },
                    { 2, "Green Sticks" },
                    { 3, "Tobacco" },
                    { 4, "Dried Herbs" },
                    { 5, "Dried Tea Leaf" }
                });

            migrationBuilder.InsertData(
                table: "OffNoteFlavor",
                columns: new[] { "OffNoteFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 6, "Rusty" },
                    { 7, "Vinegar" },
                    { 5, "Struck Matches" },
                    { 3, "Fatty" },
                    { 2, "Roast Meat" },
                    { 1, "Earthy" },
                    { 4, "Leather" }
                });

            migrationBuilder.InsertData(
                table: "PeatyFlavor",
                columns: new[] { "PeatyFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shellfish" },
                    { 2, "Brine" },
                    { 3, "Seaweed" },
                    { 4, "Iodine" },
                    { 5, "Mouthwash" },
                    { 6, "Peat Smoke" },
                    { 7, "Smoked Salmon" }
                });

            migrationBuilder.InsertData(
                table: "WineyFlavor",
                columns: new[] { "WineyFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 3, "Butter" },
                    { 8, "Red Wine" },
                    { 7, "Port" },
                    { 6, "Sherry" },
                    { 1, "Almond" },
                    { 4, "Chocolate" },
                    { 2, "Cream" },
                    { 5, "Olive" }
                });

            migrationBuilder.InsertData(
                table: "WoodyFlavor",
                columns: new[] { "WoodyFlavor_Id", "Name" },
                values: new object[,]
                {
                    { 5, "Pepper" },
                    { 6, "Cigar Box" },
                    { 4, "Clove" },
                    { 7, "Ginger" },
                    { 2, "Creme Brulee" },
                    { 1, "Caramel" },
                    { 3, "Syrup" },
                    { 8, "Liquorice" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Review_Id", "FragrantFlavor_Id", "FruityFlavor_Id", "GrainyFlavor_Id", "GrassyFlavor_Id", "OffNoteFlavor_Id", "PeatyFlavor_Id", "ReviewScore", "TastingNotes", "WineyFlavor_Id", "WoodyFlavor_Id" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1, 95, "lots of alcohol, very smokey, good neat", 1, 1 });

            migrationBuilder.InsertData(
                table: "Whiskey",
                columns: new[] { "WhiskeyId", "Distillery", "Favorite", "Name", "Review_Id", "UserId", "User_Id" },
                values: new object[] { 1, "Ardbeg", false, "10 year", 1, null, "85ee9ee5-ecbd-40d8-a31e-a5c20c59fa1c" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Review_FragrantFlavor_Id",
                table: "Review",
                column: "FragrantFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_FruityFlavor_Id",
                table: "Review",
                column: "FruityFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GrainyFlavor_Id",
                table: "Review",
                column: "GrainyFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GrassyFlavor_Id",
                table: "Review",
                column: "GrassyFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_OffNoteFlavor_Id",
                table: "Review",
                column: "OffNoteFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_PeatyFlavor_Id",
                table: "Review",
                column: "PeatyFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_WineyFlavor_Id",
                table: "Review",
                column: "WineyFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Review_WoodyFlavor_Id",
                table: "Review",
                column: "WoodyFlavor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Whiskey_Review_Id",
                table: "Whiskey",
                column: "Review_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Whiskey_UserId",
                table: "Whiskey",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Whiskey");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FragrantFlavor");

            migrationBuilder.DropTable(
                name: "FruityFlavor");

            migrationBuilder.DropTable(
                name: "GrainyFlavor");

            migrationBuilder.DropTable(
                name: "GrassyFlavor");

            migrationBuilder.DropTable(
                name: "OffNoteFlavor");

            migrationBuilder.DropTable(
                name: "PeatyFlavor");

            migrationBuilder.DropTable(
                name: "WineyFlavor");

            migrationBuilder.DropTable(
                name: "WoodyFlavor");
        }
    }
}
