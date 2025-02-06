using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TemasekShuttleV3.Migrations
{
    /// <inheritdoc />
    public partial class SeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "023f7028-ebed-4d50-a0c7-fc232628a75c", null, "Jovan", "JOVAN" },
                    { "414788fe-9218-4ce0-a736-4d28d265fdf9", null, "Triston", "TRISTON" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "b20b199c-9749-4f01-8b80-a5a174d9c502", null, "YuFeng", "YUFENG" },
                    { "f445a56e-14eb-4906-94d7-7af9e462dff9", null, "Zoey", "ZOEY" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8", 0, "c979d493-55fc-45d5-9e73-d15aa809599d", "yufeng@localhost.com", true, "YuFeng", "Driver", false, null, "YUFENG@LOCALHOST.COM", "YUFENG@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDfGpDgNX2UE/0UxgEr4MSjaAmmYL23u8WlR2aCx2DlSWh+TUdK2qc+Jw+4xfmvf+Q==", null, false, "d157e92e-b392-4664-9b38-419d4724caba", false, "yufeng@localhost.com" },
                    { "18893c71-425e-426e-8cc5-13f24d3fdc3f", 0, "3547bcd4-c56a-48e8-932e-24fbabedf390", "Triston@localhost.com", true, "Triston", "Driver", false, null, "TRISTON@LOCALHOST.COM", "TRISTON@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFMn5qPRZNCGo8o2Wo/NIwg/ffVwnduizw7y23NRZeW6/YF4uksoUl3XySUHng+lRQ==", null, false, "d18c2985-597f-4ba0-8a81-c98c6d0fbe92", false, "triston@localhost.com" },
                    { "363dd9c6-47c2-4759-bbfc-25701e3ff1049", 0, "4b40097a-4d44-4f9a-a011-a7a06cf63c29", "zoey@localhost.com", true, "Zoey", "Driver", false, null, "ZOEY@LOCALHOST.COM", "ZOEY@LOCALHOST.COM", "AQAAAAIAAYagAAAAELL2hf9u8s9gYAT06WtISrdkrlkHCfrYk4k8ShJfaJ4KLLz6ULGJhHIdqzteBDP46w==", null, false, "c784db4b-07cb-4961-9509-083da1ff491b", false, "zoey@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f53492ab-77e6-423f-a8ef-f0aad820086a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMwHwFGHDVFJK8d5PHpqqWKn1qfvYTqTkEIqff3+5ODB0b0KZsgsOmvZJw5nWpgf3w==", null, false, "1866cbb4-f11a-4303-9572-2b8aa5448c4f", false, "admin@localhost.com" },
                    { "78c9271b-e508-4214-b105-b448185b1010", 0, "38e5d922-d6e9-40ca-a5d4-af221166229f", "jovan@localhost.com", true, "Jovan", "Driver", false, null, "JOVAN@LOCALHOST.COM", "JOVAN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAOz04BDNOQ93z4ft4l+X6Q4SpvxAqrlTcHH+i8McpXF5SW/cXnSfLNpQ9eRxg7Nmg==", null, false, "c0c5ca35-51a0-4bc3-92f3-69bc28d2ce4d", false, "jovan@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 37, 22, 288, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 2, 6, 13, 37, 22, 288, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 37, 22, 288, DateTimeKind.Local).AddTicks(5662), new DateTime(2025, 2, 6, 13, 37, 22, 288, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b20b199c-9749-4f01-8b80-a5a174d9c502", "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8" },
                    { "414788fe-9218-4ce0-a736-4d28d265fdf9", "18893c71-425e-426e-8cc5-13f24d3fdc3f" },
                    { "f445a56e-14eb-4906-94d7-7af9e462dff9", "363dd9c6-47c2-4759-bbfc-25701e3ff1049" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "023f7028-ebed-4d50-a0c7-fc232628a75c", "78c9271b-e508-4214-b105-b448185b1010" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b20b199c-9749-4f01-8b80-a5a174d9c502", "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "414788fe-9218-4ce0-a736-4d28d265fdf9", "18893c71-425e-426e-8cc5-13f24d3fdc3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f445a56e-14eb-4906-94d7-7af9e462dff9", "363dd9c6-47c2-4759-bbfc-25701e3ff1049" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "023f7028-ebed-4d50-a0c7-fc232628a75c", "78c9271b-e508-4214-b105-b448185b1010" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023f7028-ebed-4d50-a0c7-fc232628a75c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "414788fe-9218-4ce0-a736-4d28d265fdf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20b199c-9749-4f01-8b80-a5a174d9c502");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f445a56e-14eb-4906-94d7-7af9e462dff9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18893c71-425e-426e-8cc5-13f24d3fdc3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "363dd9c6-47c2-4759-bbfc-25701e3ff1049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c9271b-e508-4214-b105-b448185b1010");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 4, 23, 27, 45, 880, DateTimeKind.Local).AddTicks(173), new DateTime(2025, 2, 4, 23, 27, 45, 880, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 4, 23, 27, 45, 880, DateTimeKind.Local).AddTicks(186), new DateTime(2025, 2, 4, 23, 27, 45, 880, DateTimeKind.Local).AddTicks(187) });
        }
    }
}
