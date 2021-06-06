using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class VendedoresTablaFuera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.InsertData(
                table: "Cartas",
                columns: new[] { "Id", "CarritoId", "Img", "JuegoId", "Name" },
                values: new object[] { 2, null, "https://static.cardmarket.com/img/60b895275f86d14cc1fe1090647467de/items/51/EVO/293474.jpg", 1, "Imakuni?'s Doduo (EVO 112)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cartas",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "Vendedores",
                columns: new[] { "Id", "IdUser" },
                values: new object[] { 1, 1 });
        }
    }
}
