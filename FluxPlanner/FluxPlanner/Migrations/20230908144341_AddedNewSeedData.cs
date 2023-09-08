using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxPlanner.Migrations
{
    public partial class AddedNewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "FloorId", "FloorNumber" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "AvailableDesks", "FloorId", "RoomName", "TotalDesks" },
                values: new object[,]
                {
                    { 1, 30, 1, "ADV D TLS", 30 },
                    { 2, 20, 1, "ADV D PAD", 20 },
                    { 3, 30, 2, "ADV D ADC", 30 },
                    { 4, 10, 3, "ADV D FRS", 10 },
                    { 5, 30, 4, "ADV D JRD", 30 }
                });

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "DeskId", "IsDeskAvailable", "RoomId" },
                values: new object[,]
                {
                    { 1, true, 1 },
                    { 2, true, 1 },
                    { 3, true, 1 },
                    { 4, true, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "DeskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 1);
        }
    }
}
