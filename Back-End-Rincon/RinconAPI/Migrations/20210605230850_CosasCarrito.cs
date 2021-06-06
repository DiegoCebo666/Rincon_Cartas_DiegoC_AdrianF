using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class CosasCarrito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartasVendedor_Carritos_CarritoId",
                table: "CartasVendedor");

            migrationBuilder.DropIndex(
                name: "IX_CartasVendedor_CarritoId",
                table: "CartasVendedor");

            migrationBuilder.DropColumn(
                name: "CarritoId",
                table: "CartasVendedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarritoId",
                table: "CartasVendedor",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartasVendedor_CarritoId",
                table: "CartasVendedor",
                column: "CarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartasVendedor_Carritos_CarritoId",
                table: "CartasVendedor",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
