using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class ListsAndChangesCartaVendedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "CartasVendedor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Idioma",
                table: "CartasVendedor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CartasVendedor",
                keyColumn: "CartaVendedorId",
                keyValue: 1,
                columns: new[] { "Estado", "Idioma" },
                values: new object[] { "Perfecta", "es" });

            migrationBuilder.UpdateData(
                table: "CartasVendedor",
                keyColumn: "CartaVendedorId",
                keyValue: 2,
                columns: new[] { "Estado", "Idioma" },
                values: new object[] { "Casi Perfecta", "es" });

            migrationBuilder.UpdateData(
                table: "CartasVendedor",
                keyColumn: "CartaVendedorId",
                keyValue: 3,
                columns: new[] { "Estado", "Idioma" },
                values: new object[] { "Excelente", "en" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "CartasVendedor");

            migrationBuilder.DropColumn(
                name: "Idioma",
                table: "CartasVendedor");
        }
    }
}
