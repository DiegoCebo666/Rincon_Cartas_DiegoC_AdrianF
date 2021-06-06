using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartasVendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CartaId = table.Column<int>(type: "INTEGER", nullable: false),
                    VendedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartasVendedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdUser = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cartas",
                columns: new[] { "Id", "CarritoId", "Img", "JuegoId", "Name" },
                values: new object[] { 1, null, "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg", 1, "Dunsparce (NDI 54)" });

            migrationBuilder.InsertData(
                table: "CartasVendedor",
                columns: new[] { "Id", "Cantidad", "CartaId", "Precio", "VendedorId" },
                values: new object[] { 1, 30, 1, 100.0, 1 });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Pokemon" });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Yu-Gi-Oh" });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Magic" });

            migrationBuilder.InsertData(
                table: "Juegos",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Dragon Ball" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Name", "Password", "Seller" },
                values: new object[] { 1, "Pipo", "Pipo", true });

            migrationBuilder.InsertData(
                table: "Vendedores",
                columns: new[] { "Id", "IdUser" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartasVendedor");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DeleteData(
                table: "Cartas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Juegos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
