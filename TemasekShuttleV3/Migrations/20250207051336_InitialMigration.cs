using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TemasekShuttleV3.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ScheduleOccurrenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusCapacity = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverContact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackRating = table.Column<int>(type: "int", nullable: false),
                    FeedbackContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniquePaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentAmountId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeakPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NonpeakPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentAmount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusScheduleTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpareDriver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleOccurrence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusScheduleTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleOccurrence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cc929e90-2902-4d56-b9b3-663d1acba20f", null, "driver", "DRIVER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8", 0, "d8f45ef2-2256-4a8b-b36d-991ada5759ef", "yufeng@localhost.com", true, "YuFeng", "Driver", false, null, "YUFENG@LOCALHOST.COM", "YUFENG@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEdvORZm1yrA7k/J566UE+bp+UcVxr27N3VAiFa5Q4HEMJZlFKtMs1Yt+tdiSPB9OQ==", null, false, "55152716-a543-4782-a879-fcdd46c34543", false, "yufeng@localhost.com" },
                    { "18893c71-425e-426e-8cc5-13f24d3fdc3f", 0, "0c9cb4ce-3250-4343-b5f2-4ddf614eba78", "Triston@localhost.com", true, "Triston", "Driver", false, null, "TRISTON@LOCALHOST.COM", "TRISTON@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFz38qRFEAOyDLiG7JXX7Nv1kBfIGTFQJ47oYa95h4ldZId1uVJ8KgIayhREjkA8wg==", null, false, "6d520897-3ab5-49c9-ac8d-ec3ee6d2c52e", false, "triston@localhost.com" },
                    { "363dd9c6-47c2-4759-bbfc-25701e3ff1049", 0, "5919e6d5-b6cc-4512-9a0b-80c95753d065", "zoey@localhost.com", true, "Zoey", "Driver", false, null, "ZOEY@LOCALHOST.COM", "ZOEY@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGYYc54iA+DGasksJWu0j+vEhhiqGMpTD0e8Z006OWvt0sGZxmSB4iDyzgcwR/QMEw==", null, false, "1aae53af-8ba5-4bea-b640-ed8ca8a19635", false, "zoey@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d211560e-c626-4ab4-84f9-6d95fd74be6b", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAa7DVQvNhups04mPz+YVeR+/+ZBJCLV9vSJh3J2J6vufBDBjYs0iBuKJbQqHsOPEQ==", null, false, "c2fbe23e-28fb-43f5-b6b0-dfb1027a0f2a", false, "admin@localhost.com" },
                    { "78c9271b-e508-4214-b105-b448185b1010", 0, "7fa54f15-0072-46e1-9da7-1459af85fb15", "jovan@localhost.com", true, "Jovan", "Driver", false, null, "JOVAN@LOCALHOST.COM", "JOVAN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHTQT5s8dMsix4J8ecYQ6JUqDJzn0w1OFBgHXb4+Ydbi0KW22Ck4qU2NtOz7vS2rcg==", null, false, "0a516573-889c-458e-8bec-7e384b5dfd2a", false, "jovan@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Bus",
                columns: new[] { "Id", "BusCapacity", "BusPlate", "ScheduleId" },
                values: new object[,]
                {
                    { 1, 40, "SA4B1G3R", null },
                    { 2, 40, "PM0T7J9D", null }
                });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "Id", "DriverContact", "DriverName" },
                values: new object[,]
                {
                    { 1, "81234567", "Jovan" },
                    { 2, "91234567", "Zoey" },
                    { 3, "85234891", "Yu Feng" },
                    { 4, "98257845", "Triston" }
                });

            migrationBuilder.InsertData(
                table: "PaymentAmount",
                columns: new[] { "Id", "NonpeakPrice", "PeakPrice" },
                values: new object[] { 1, 1.50m, 2.50m });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "BusScheduleDate", "BusScheduleTime", "DriverDate", "DriverId", "DriverTime", "ScheduleLocation", "SpareDriver" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "Tampines East MRT Exit C", "" },
                    { 2, new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2025, 8, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), "Punggol MRT Exit A", "" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleOccurrence",
                columns: new[] { "Id", "BusScheduleDate", "BusScheduleTime", "ScheduleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 7, 13, 13, 35, 410, DateTimeKind.Local).AddTicks(6850), new DateTime(2025, 2, 7, 13, 13, 35, 410, DateTimeKind.Local).AddTicks(6863), 0 },
                    { 2, new DateTime(2025, 2, 7, 13, 13, 35, 410, DateTimeKind.Local).AddTicks(6864), new DateTime(2025, 2, 7, 13, 13, 35, 410, DateTimeKind.Local).AddTicks(6864), 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cc929e90-2902-4d56-b9b3-663d1acba20f", "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8" },
                    { "cc929e90-2902-4d56-b9b3-663d1acba20f", "18893c71-425e-426e-8cc5-13f24d3fdc3f" },
                    { "cc929e90-2902-4d56-b9b3-663d1acba20f", "363dd9c6-47c2-4759-bbfc-25701e3ff1049" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "cc929e90-2902-4d56-b9b3-663d1acba20f", "78c9271b-e508-4214-b105-b448185b1010" }
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
        }

        /// <inheritdoc />
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
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Bus");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PaymentAmount");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "ScheduleOccurrence");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
