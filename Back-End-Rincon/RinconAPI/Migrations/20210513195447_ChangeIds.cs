using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class ChangeIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Carritos_CartId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "Pedidos",
                newName: "CartCarritoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pedidos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_CartId",
                table: "Pedidos",
                newName: "IX_Pedidos_CartCarritoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Juegos",
                newName: "JuegoId");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "CartasVendedor",
                newName: "VendedorFId");

            migrationBuilder.RenameColumn(
                name: "CartaId",
                table: "CartasVendedor",
                newName: "CartaFId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CartasVendedor",
                newName: "CartaVendedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cartas",
                newName: "CartaId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Carritos",
                newName: "Usuario2Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carritos",
                newName: "CarritoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Carritos_CartCarritoId",
                table: "Pedidos",
                column: "CartCarritoId",
                principalTable: "Carritos",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Carritos_CartCarritoId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CartCarritoId",
                table: "Pedidos",
                newName: "CartId");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Pedidos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_CartCarritoId",
                table: "Pedidos",
                newName: "IX_Pedidos_CartId");

            migrationBuilder.RenameColumn(
                name: "JuegoId",
                table: "Juegos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VendedorFId",
                table: "CartasVendedor",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "CartaFId",
                table: "CartasVendedor",
                newName: "CartaId");

            migrationBuilder.RenameColumn(
                name: "CartaVendedorId",
                table: "CartasVendedor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CartaId",
                table: "Cartas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Usuario2Id",
                table: "Carritos",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CarritoId",
                table: "Carritos",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Carritos_CartId",
                table: "Pedidos",
                column: "CartId",
                principalTable: "Carritos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
