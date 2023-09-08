using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxPlanner.Migrations
{
    public partial class ModifiedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "WorkLocation",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "WorkFromOffice",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 1);

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

            migrationBuilder.DropColumn(
                name: "WorkFromOffice",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "WorkLocation",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "WorkLocation" },
                values: new object[] { 1, "test@t.com", "Test", "Test", "WFH" });
        }
    }
}
