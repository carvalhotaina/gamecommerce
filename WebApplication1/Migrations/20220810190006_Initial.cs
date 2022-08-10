using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "desenvolvedors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desenvolvedors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "empressas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empressas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    preço = table.Column<double>(type: "float", nullable: false),
                    GameCat = table.Column<int>(type: "int", nullable: false),
                    Plataformasid = table.Column<int>(type: "int", nullable: false),
                    empressaid = table.Column<int>(type: "int", nullable: false)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.id);
                    table.ForeignKey(
                        name: "FK_Games_empressas_empressaId",
                        column: x => x.empressaid,
                        principalTable: "empressas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Plataformas_PlataformasId",
                        column: x => x.Plataformasid,
                        principalTable: "Plataformas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "desenvolvedores_games",
                columns: table => new
                {
                    gameId = table.Column<int>(type: "int", nullable: false),
                    DesenvolvedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desenvolvedores_games", x => new { x.DesenvolvedorId, x.gameId });
                    table.ForeignKey(
                        name: "FK_desenvolvedores_games_desenvolvedors_DesenvolvedorId",
                        column: x => x.DesenvolvedorId,
                        principalTable: "desenvolvedors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_desenvolvedores_games_Games_gameId",
                        column: x => x.gameId,
                        principalTable: "Games",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_desenvolvedores_games_gameId",
                table: "desenvolvedores_games",
                column: "gameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_empressaId",
                table: "Games",
                column: "empressaId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlataformasId",
                table: "Games",
                column: "PlataformasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "desenvolvedores_games");

            migrationBuilder.DropTable(
                name: "desenvolvedors");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "empressas");

            migrationBuilder.DropTable(
                name: "Plataformas");
        }
    }
}
