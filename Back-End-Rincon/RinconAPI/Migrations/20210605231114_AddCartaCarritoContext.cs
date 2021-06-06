using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class AddCartaCarritoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartasCarrito",
                columns: table => new
                {
                    CartaCarritoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarritoFId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartaVendedorFId = table.Column<int>(type: "INTEGER", nullable: false),
                    FCantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartasCarrito", x => x.CartaCarritoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartasCarrito");
        }
    }
}
