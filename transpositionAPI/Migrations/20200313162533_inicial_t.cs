using Microsoft.EntityFrameworkCore.Migrations;

namespace transpositionAPI.Migrations
{
    public partial class inicial_t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acordes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcordesComaticas = table.Column<string>(nullable: false),
                    acordesComaticasMayores = table.Column<string>(nullable: true),
                    acordesComaticasMenores = table.Column<string>(nullable: true),
                    acordesSeptimaMayor = table.Column<string>(nullable: true),
                    acordesSeptimaMenor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acordes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acordesComaticos = table.Column<string>(nullable: false),
                    acordesComaticosMayores = table.Column<string>(nullable: true),
                    acordesComaticosMenores = table.Column<string>(nullable: true),
                    acordesSeptimaMayor = table.Column<string>(nullable: true),
                    acordesSeptimaMenor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acordes");

            migrationBuilder.DropTable(
                name: "notas");
        }
    }
}
