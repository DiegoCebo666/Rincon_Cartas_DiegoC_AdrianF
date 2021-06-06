using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class AddedDataToCartaVendedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartaFName",
                table: "CartasVendedor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FImg",
                table: "CartasVendedor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CartasVendedor",
                keyColumn: "CartaVendedorId",
                keyValue: 1,
                columns: new[] { "CartaFName", "FImg" },
                values: new object[] { "Dunsparce (NDI 54)", "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartaFName",
                table: "CartasVendedor");

            migrationBuilder.DropColumn(
                name: "FImg",
                table: "CartasVendedor");
        }
    }
}
