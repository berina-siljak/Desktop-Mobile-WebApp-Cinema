using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class finalTouch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ocjene");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    FilmID = table.Column<int>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Filmovi_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_Kupci_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_FilmID",
                table: "Ocjene",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KupacID",
                table: "Ocjene",
                column: "KupacID");
        }
    }
}
