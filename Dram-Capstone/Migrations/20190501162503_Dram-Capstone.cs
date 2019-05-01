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
                    FragrantFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FragrantFlavor", x => x.FragrantFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "FruityFlavor",
                columns: table => new
                {
                    FruityFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruityFlavor", x => x.FruityFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "GrainyFlavor",
                columns: table => new
                {
                    GrainyFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrainyFlavor", x => x.GrainyFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "GrassyFlavor",
                columns: table => new
                {
                    GrassyFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrassyFlavor", x => x.GrassyFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "OffNoteFlavor",
                columns: table => new
                {
                    OffNoteFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffNoteFlavor", x => x.OffNoteFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "PeatyFlavor",
                columns: table => new
                {
                    PeatyFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeatyFlavor", x => x.PeatyFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "WineyFlavor",
                columns: table => new
                {
                    WineyFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineyFlavor", x => x.WineyFlavorId);
                });

            migrationBuilder.CreateTable(
                name: "WoodyFlavor",
                columns: table => new
                {
                    WoodyFlavorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodyFlavor", x => x.WoodyFlavorId);
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
                name: "Whiskey",
                columns: table => new
                {
                    WhiskeyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Distillery = table.Column<string>(nullable: false),
                    WhiskeyReview_Id = table.Column<int>(nullable: true),
                    User_Id = table.Column<string>(nullable: false),
                    Favorite = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whiskey", x => x.WhiskeyId);
                    table.ForeignKey(
                        name: "FK_Whiskey_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    TastingNotes = table.Column<string>(nullable: true),
                    ReviewScore = table.Column<int>(nullable: false),
                    WoodyFlavor_Id = table.Column<int>(nullable: false),
                    WineyFlavor_Id = table.Column<int>(nullable: false),
                    OffNotesFlavor_Id = table.Column<int>(nullable: false),
                    FruityFlavor_Id = table.Column<int>(nullable: false),
                    FragrantFlavor_Id = table.Column<int>(nullable: false),
                    PeatyFlavor_Id = table.Column<int>(nullable: false),
                    GrainyFlavor_Id = table.Column<int>(nullable: false),
                    GrassyFlavor_Id = table.Column<int>(nullable: false),
                    WhiskeyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Whiskey_WhiskeyId",
                        column: x => x.WhiskeyId,
                        principalTable: "Whiskey",
                        principalColumn: "WhiskeyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "f17ffaee-4be6-4626-827d-cfad97ac21fd", 0, "567148f4-a715-42e8-88fe-01973e08b01c", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", null, "AQAAAAEAACcQAAAAEKFRHJbHX8ibl+62D4/NRoP2oDJz1KmD50cMwMqcJgdD+KyFQ2LVL/4KQX/7Exo2nw==", null, false, "fd1370d9-2e83-453a-8a36-d8cce0d19b05", false, null, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "FragrantFlavor",
                columns: new[] { "FragrantFlavorId", "Name" },
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
                columns: new[] { "FruityFlavorId", "Name" },
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
                columns: new[] { "GrainyFlavorId", "Name" },
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
                columns: new[] { "GrassyFlavorId", "Name" },
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
                columns: new[] { "OffNoteFlavorId", "Name" },
                values: new object[,]
                {
                    { 6, "Rusty" },
                    { 7, "Vinegar" },
                    { 5, "Struck Matches" },
                    { 4, "Leather" },
                    { 3, "Fatty" },
                    { 2, "Roast Meat" },
                    { 1, "Earthy" }
                });

            migrationBuilder.InsertData(
                table: "PeatyFlavor",
                columns: new[] { "PeatyFlavorId", "Name" },
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
                table: "Review",
                columns: new[] { "ReviewId", "FragrantFlavor_Id", "FruityFlavor_Id", "GrainyFlavor_Id", "GrassyFlavor_Id", "OffNotesFlavor_Id", "PeatyFlavor_Id", "ReviewScore", "TastingNotes", "WhiskeyId", "WineyFlavor_Id", "WoodyFlavor_Id" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1, 95, "lots of alcohol, very smokey, good neat", null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Whiskey",
                columns: new[] { "WhiskeyId", "ApplicationUserId", "Distillery", "Favorite", "Name", "User_Id", "WhiskeyReview_Id" },
                values: new object[] { 1, null, "Ardbeg", false, "10 year", "f17ffaee-4be6-4626-827d-cfad97ac21fd", 1 });

            migrationBuilder.InsertData(
                table: "WineyFlavor",
                columns: new[] { "WineyFlavorId", "Name" },
                values: new object[,]
                {
                    { 8, "Red Wine" },
                    { 7, "Port" },
                    { 6, "Sherry" },
                    { 5, "Olive" },
                    { 2, "Cream" },
                    { 3, "Butter" },
                    { 1, "Almond" },
                    { 4, "Chocolate" }
                });

            migrationBuilder.InsertData(
                table: "WoodyFlavor",
                columns: new[] { "WoodyFlavorId", "Name" },
                values: new object[,]
                {
                    { 7, "Ginger" },
                    { 1, "Caramel" },
                    { 2, "Creme Brulee" },
                    { 3, "Caramel" },
                    { 4, "Clove" },
                    { 5, "Pepper" },
                    { 6, "Cigar Box" },
                    { 8, "Liquorice" }
                });

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
                name: "IX_Review_WhiskeyId",
                table: "Review",
                column: "WhiskeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Whiskey_ApplicationUserId",
                table: "Whiskey",
                column: "ApplicationUserId");
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
                name: "Review");

            migrationBuilder.DropTable(
                name: "WineyFlavor");

            migrationBuilder.DropTable(
                name: "WoodyFlavor");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Whiskey");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
