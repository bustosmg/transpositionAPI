using Microsoft.EntityFrameworkCore.Migrations;

namespace transpositionAPI.Migrations
{
    public partial class inicial_t2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "acordesComaticos",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "acordesComaticosMayores",
                table: "notas");

            migrationBuilder.DropColumn(
                name: "acordesComaticosMenores",
                table: "notas");

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticos",
                table: "notas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticosMayores",
                table: "notas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticosMenores",
                table: "notas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "acordesComaticos",
                table: "notas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "acordesComaticosMayores",
                table: "notas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesComaticosMenores",
                table: "notas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
