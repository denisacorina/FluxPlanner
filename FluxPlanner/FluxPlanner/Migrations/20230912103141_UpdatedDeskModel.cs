using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxPlanner.Migrations
{
    public partial class UpdatedDeskModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeskAvailable",
                table: "Desks");

            migrationBuilder.UpdateData(
                table: "DeskReservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 12, 10, 31, 41, 168, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 9, 12, 10, 31, 41, 168, DateTimeKind.Utc).AddTicks(2122) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeskAvailable",
                table: "Desks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DeskReservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 52, 13, 616, DateTimeKind.Utc).AddTicks(586), new DateTime(2023, 9, 8, 14, 52, 13, 616, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 1,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 2,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 3,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 4,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 5,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 6,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 7,
                column: "IsDeskAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 8,
                column: "IsDeskAvailable",
                value: true);
        }
    }
}
