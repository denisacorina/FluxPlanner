using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxPlanner.Migrations
{
    public partial class CreatedDatabaseAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeskReservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 12, 13, 6, 59, 955, DateTimeKind.Utc).AddTicks(566), new DateTime(2023, 9, 12, 13, 6, 59, 955, DateTimeKind.Utc).AddTicks(564) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeskReservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 52, 13, 616, DateTimeKind.Utc).AddTicks(586), new DateTime(2023, 9, 8, 14, 52, 13, 616, DateTimeKind.Utc).AddTicks(585) });
        }
    }
}
