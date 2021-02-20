using Microsoft.EntityFrameworkCore.Migrations;

namespace SangereanVirgilProiectMedii.Migrations
{
    public partial class CategorieFilm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudioFilmID",
                table: "Film",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeCategorie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudioFilm",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeStudio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudioFilm", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieFilm",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmID = table.Column<int>(nullable: false),
                    CategorieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieFilm", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategorieFilm_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieFilm_Film_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Film",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_StudioFilmID",
                table: "Film",
                column: "StudioFilmID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieFilm_CategorieID",
                table: "CategorieFilm",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieFilm_FilmID",
                table: "CategorieFilm",
                column: "FilmID");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_StudioFilm_StudioFilmID",
                table: "Film",
                column: "StudioFilmID",
                principalTable: "StudioFilm",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_StudioFilm_StudioFilmID",
                table: "Film");

            migrationBuilder.DropTable(
                name: "CategorieFilm");

            migrationBuilder.DropTable(
                name: "StudioFilm");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Film_StudioFilmID",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "StudioFilmID",
                table: "Film");
        }
    }
}
