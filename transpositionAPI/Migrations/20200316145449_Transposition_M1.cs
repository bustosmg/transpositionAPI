using Microsoft.EntityFrameworkCore.Migrations;

namespace transpositionAPI.Migrations
{
    public partial class Transposition_M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "acordesCromaticos",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "acordesCromaticosMayores",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "acordesCromaticosMenores",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "acordesSeptimaMayor",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "acordesSeptimaMenor",
                table: "notas");

            migrationBuilder.AddColumn<string>(
                name: "notasCromaticas",
                table: "notas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "notasCromaticasMayores",
                table: "notas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notasCromaticasMenores",
                table: "notas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notasCromaticasSeptimaMayores",
                table: "notas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notasCromaticasSeptimaMenores",
                table: "notas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "notasCromaticas",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "notasCromaticasMayores",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "notasCromaticasMenores",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "notasCromaticasSeptimaMayores",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "notasCromaticasSeptimaMenores",
                table: "notas");

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticos",
                table: "notas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticosMayores",
                table: "notas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticosMenores",
                table: "notas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesSeptimaMayor",
                table: "notas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesSeptimaMenor",
                table: "notas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
