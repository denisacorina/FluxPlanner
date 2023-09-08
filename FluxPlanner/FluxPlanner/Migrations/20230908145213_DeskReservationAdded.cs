using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxPlanner.Migrations
{
    public partial class DeskReservationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "DeskReservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationStatus",
                table: "DeskReservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "DeskReservations",
                columns: new[] { "ReservationId", "DeskId", "EndDate", "ReservationStatus", "StartDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(2023, 9, 8, 14, 52, 13, 616, DateTimeKind.Utc).AddTicks(586), 0, new DateTime(2023, 9, 8, 14, 52, 13, 616, DateTimeKind.Utc).AddTicks(585), 1 });

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "DeskId", "IsDeskAvailable", "RoomId" },
                values: new object[,]
                {
                    { 5, true, 2 },
                    { 6, true, 3 },
                    { 7, true, 4 },
                    { 8, true, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeskReservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "ReservationStatus",
                table: "DeskReservations");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "DeskReservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
