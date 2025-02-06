using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemasekShuttleV3.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92a4a8d3-e2a7-4baf-a7d4-5d5750709532", "AQAAAAIAAYagAAAAEJv/mZDHEdEKNtC+sWwccleXivXikK9+p7SSR63T5XuL8gqfyKQjPPlRBZI0UhnLSA==", "d1ee0daf-a1a2-4a46-b1d3-db2ac2f7be91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18893c71-425e-426e-8cc5-13f24d3fdc3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0f39542-d3eb-479c-9aef-743c4d53a7b7", "AQAAAAIAAYagAAAAEIh0u5L35W0zC+Z439E14MvTyYzJtRaniUJTztbFG6xUrr/2kMImx9kRBuigTPKy7g==", "46b881cf-9318-4579-8de1-167cd2a4f98d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "363dd9c6-47c2-4759-bbfc-25701e3ff1049",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe2a6f9-46a4-4ff6-9fd9-f1f717637d65", "AQAAAAIAAYagAAAAEObINWoQfrIVMo+520vy9CuA/+JWSW1osaugZ0dHDsXng7o2x+uB+tMqMp4m0rtVCA==", "a6baee1b-762d-41ae-9783-03331b51c0d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4de46a1f-761c-4002-9fee-1cccb6c5bfd5", "AQAAAAIAAYagAAAAEEFPVnuNyDrM14X6/2QQWkw6Gb3NvVrYb0ZKyti7eiE47bN4jFcjHNk0OTx99lQt+A==", "a7a9ccc7-2c66-40c5-bdaa-39d3aad5d15c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c9271b-e508-4214-b105-b448185b1010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "459328df-3736-4ff8-a763-12a71afb9840", "AQAAAAIAAYagAAAAEJWXmglXPn5EgMa77+A3J9iESFe/KXgPEavO5TdjMKSuCRQEI9qRWl0yUU8locZhfA==", "4630c4af-21a2-452f-b4f7-5e9567be8ad0" });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 37, 50, 699, DateTimeKind.Local).AddTicks(5011), new DateTime(2025, 2, 6, 13, 37, 50, 699, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 37, 50, 699, DateTimeKind.Local).AddTicks(5024), new DateTime(2025, 2, 6, 13, 37, 50, 699, DateTimeKind.Local).AddTicks(5024) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c979d493-55fc-45d5-9e73-d15aa809599d", "AQAAAAIAAYagAAAAEDfGpDgNX2UE/0UxgEr4MSjaAmmYL23u8WlR2aCx2DlSWh+TUdK2qc+Jw+4xfmvf+Q==", "d157e92e-b392-4664-9b38-419d4724caba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18893c71-425e-426e-8cc5-13f24d3fdc3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3547bcd4-c56a-48e8-932e-24fbabedf390", "AQAAAAIAAYagAAAAEFMn5qPRZNCGo8o2Wo/NIwg/ffVwnduizw7y23NRZeW6/YF4uksoUl3XySUHng+lRQ==", "d18c2985-597f-4ba0-8a81-c98c6d0fbe92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "363dd9c6-47c2-4759-bbfc-25701e3ff1049",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b40097a-4d44-4f9a-a011-a7a06cf63c29", "AQAAAAIAAYagAAAAELL2hf9u8s9gYAT06WtISrdkrlkHCfrYk4k8ShJfaJ4KLLz6ULGJhHIdqzteBDP46w==", "c784db4b-07cb-4961-9509-083da1ff491b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f53492ab-77e6-423f-a8ef-f0aad820086a", "AQAAAAIAAYagAAAAEMwHwFGHDVFJK8d5PHpqqWKn1qfvYTqTkEIqff3+5ODB0b0KZsgsOmvZJw5nWpgf3w==", "1866cbb4-f11a-4303-9572-2b8aa5448c4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c9271b-e508-4214-b105-b448185b1010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e5d922-d6e9-40ca-a5d4-af221166229f", "AQAAAAIAAYagAAAAEAOz04BDNOQ93z4ft4l+X6Q4SpvxAqrlTcHH+i8McpXF5SW/cXnSfLNpQ9eRxg7Nmg==", "c0c5ca35-51a0-4bc3-92f3-69bc28d2ce4d" });

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
        }
    }
}
