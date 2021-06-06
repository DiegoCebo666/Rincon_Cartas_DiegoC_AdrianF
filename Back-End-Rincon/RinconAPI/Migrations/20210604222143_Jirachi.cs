using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class Jirachi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cartas",
                keyColumn: "CartaId",
                keyValue: 23,
                column: "Img",
                value: "https://static.cardmarket.com/img/4b90c545640b29a90f983e574decb2d9/items/51/VIV/512305.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cartas",
                keyColumn: "CartaId",
                keyValue: 23,
                column: "Img",
                value: "https://static.cardmarket.com/img/d3a1c2a0bbd77a12645671b7e6d94845/items/51/CEC/408754.jpg");
        }
    }
}
