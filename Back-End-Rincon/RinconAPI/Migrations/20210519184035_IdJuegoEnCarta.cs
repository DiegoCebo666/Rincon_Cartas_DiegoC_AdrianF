using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class IdJuegoEnCarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JuegoId",
                table: "Cartas",
                newName: "JuegoFId");

            migrationBuilder.InsertData(
                table: "CartasVendedor",
                columns: new[] { "CartaVendedorId", "Cantidad", "CartaFId", "CartaFName", "FImg", "Precio", "VendedorFId" },
                values: new object[] { 2, 30, 2, "Imakuni?'s Doduo (EVO 112)", "https://static.cardmarket.com/img/60b895275f86d14cc1fe1090647467de/items/51/EVO/293474.jpg", 100.0, 1 });

            migrationBuilder.InsertData(
                table: "CartasVendedor",
                columns: new[] { "CartaVendedorId", "Cantidad", "CartaFId", "CartaFName", "FImg", "Precio", "VendedorFId" },
                values: new object[] { 3, 20, 1, "Dunsparce (NDI 54)", "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg", 50.0, 2 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Email",
                value: "pipo@gmail.com");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Password", "Seller", "UserName" },
                values: new object[] { 2, "papo@gmail.com", "Papo", true, "Papo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CartasVendedor",
                keyColumn: "CartaVendedorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CartasVendedor",
                keyColumn: "CartaVendedorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "JuegoFId",
                table: "Cartas",
                newName: "JuegoId");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Email",
                value: "diegocebo7@gmail.com");
        }
    }
}
