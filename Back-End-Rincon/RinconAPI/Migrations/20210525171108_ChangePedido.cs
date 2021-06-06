using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class ChangePedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartas_Carritos_CarritoId",
                table: "Cartas");

            migrationBuilder.DropIndex(
                name: "IX_Cartas_CarritoId",
                table: "Cartas");

            migrationBuilder.DropColumn(
                name: "CarritoId",
                table: "Cartas");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CarritoId",
                table: "Cartas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cartas_CarritoId",
                table: "Cartas",
                column: "CarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cartas_Carritos_CarritoId",
                table: "Cartas",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
