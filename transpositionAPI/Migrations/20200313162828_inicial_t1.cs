using Microsoft.EntityFrameworkCore.Migrations;

namespace transpositionAPI.Migrations
{
    public partial class inicial_t1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcordesComaticas",
                table: "acordes");

            migrationBuilder.DropColumn(
                name: "acordesComaticasMayores",
                table: "acordes");

            migrationBuilder.DropColumn(
                name: "acordesComaticasMenores",
                table: "acordes");

            migrationBuilder.AddColumn<string>(
                name: "AcordesCromaticas",
                table: "acordes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticasMayores",
                table: "acordes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesCromaticasMenores",
                table: "acordes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcordesCromaticas",
                table: "acordes");

            migrationBuilder.DropColumn(
                name: "acordesCromaticasMayores",
                table: "acordes");

            migrationBuilder.DropColumn(
                name: "acordesCromaticasMenores",
                table: "acordes");

            migrationBuilder.AddColumn<string>(
                name: "AcordesComaticas",
                table: "acordes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "acordesComaticasMayores",
                table: "acordes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "acordesComaticasMenores",
                table: "acordes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
