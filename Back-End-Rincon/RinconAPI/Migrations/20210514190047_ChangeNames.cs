using Microsoft.EntityFrameworkCore.Migrations;

namespace RinconAPI.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Usuarios",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Juegos",
                newName: "JuegoName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cartas",
                newName: "CartaName");

            migrationBuilder.RenameColumn(
                name: "Usuario2Id",
                table: "Carritos",
                newName: "UsuarioFId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Usuarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "JuegoName",
                table: "Juegos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CartaName",
                table: "Cartas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UsuarioFId",
                table: "Carritos",
                newName: "Usuario2Id");
        }
    }
}
