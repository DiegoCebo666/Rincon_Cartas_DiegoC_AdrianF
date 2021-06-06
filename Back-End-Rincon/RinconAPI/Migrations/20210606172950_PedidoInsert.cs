using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class PedidoInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Carritos_CartCarritoId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CartCarritoId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CartCarritoId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "CartFId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartFId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "CartCarritoId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CartCarritoId",
                table: "Pedidos",
                column: "CartCarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Carritos_CartCarritoId",
                table: "Pedidos",
                column: "CartCarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
