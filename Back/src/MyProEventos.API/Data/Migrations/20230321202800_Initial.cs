using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProEventos.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventoLocal = table.Column<string>(type: "TEXT", nullable: true),
                    EventoData = table.Column<string>(type: "TEXT", nullable: true),
                    EventoTema = table.Column<string>(type: "TEXT", nullable: true),
                    EventoQtdPessoas = table.Column<int>(type: "INTEGER", nullable: false),
                    EventoLote = table.Column<string>(type: "TEXT", nullable: true),
                    EventoImagemURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
