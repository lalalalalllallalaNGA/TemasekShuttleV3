using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemasekShuttleV3.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b8ef920-dad6-4d01-9afa-78c3cb9d92b8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e263b946-a182-42a8-ab8e-3c642dd1b6a4", "AQAAAAIAAYagAAAAEFGcfVVxwr5SvXgrdQ7oDlx76dYLDOpQcghLGjDKQffmqvOGUDDrVcMozxKb49ORxQ==", "0e22ba5f-2e05-4f24-bac0-31e53201c139" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18893c71-425e-426e-8cc5-13f24d3fdc3f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31055dd-67cc-4578-a26e-32d8082d1eed", "AQAAAAIAAYagAAAAEC6VdQrjrK3SOAadOxdrkpKjkK7epd9BoIRhKavvtvWpRiukK3OMxmJeTdB3DL21Gg==", "64a120d8-675b-4593-b832-4fabb4fc65ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "363dd9c6-47c2-4759-bbfc-25701e3ff1049",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b30f812-9074-40a0-9a67-2388e4bff120", "AQAAAAIAAYagAAAAEPnrxnDPOzKjXGe1vN0aDmEJ1kK7XqRyO9Dc6iFOceqi+Bp1c/0EamMT1Ys3lHtT+A==", "99310573-73d9-4ea8-b080-dd7c0567fb9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0730a30-e5d4-42de-98b9-9c3ebf77490e", "AQAAAAIAAYagAAAAEKHaDREY1ZesBMGnGQtz0Clk/fmkNYbTMqdL+BgCG/FP2v1+CdS60cQUPYow/4TFFA==", "ef42f2b2-8ece-40f4-bebd-cab798694687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c9271b-e508-4214-b105-b448185b1010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30d7e7ef-0e6c-4fbe-af08-44bad1428610", "AQAAAAIAAYagAAAAEG70M/TVu40FVanJgnKgIqYRppErbxMbgDE8vXm9psB3E2fcer5NhSchVPzmleSIsg==", "1de2b507-9a05-4222-adb6-5c667761acc6" });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 38, 14, 207, DateTimeKind.Local).AddTicks(4969), new DateTime(2025, 2, 6, 13, 38, 14, 207, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusScheduleDate", "BusScheduleTime" },
                values: new object[] { new DateTime(2025, 2, 6, 13, 38, 14, 207, DateTimeKind.Local).AddTicks(4981), new DateTime(2025, 2, 6, 13, 38, 14, 207, DateTimeKind.Local).AddTicks(4981) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
