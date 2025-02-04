using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TemasekShuttleV3.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 1, new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6242), new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6254), 0 },
                    { 2, new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6258), new DateTime(2025, 2, 4, 21, 37, 27, 963, DateTimeKind.Local).AddTicks(6259), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PaymentAmount",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScheduleOccurrence",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
