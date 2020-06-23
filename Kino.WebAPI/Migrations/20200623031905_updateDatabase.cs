using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class updateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    KomentarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sadrzaj = table.Column<string>(nullable: true),
                    VrijemeKreiranja = table.Column<DateTime>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    FilmID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.KomentarID);
                    table.ForeignKey(
                        name: "FK_Komentari_Filmovi_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komentari_Kupci_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_FilmID",
                table: "Komentari",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_KupacID",
                table: "Komentari",
                column: "KupacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    ObavijestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Tekst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.ObavijestID);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cijena = table.Column<decimal>(nullable: false),
                    Popust = table.Column<decimal>(nullable: false),
                    UlaznicaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.UplataID);
                    table.ForeignKey(
                        name: "FK_Uplate_Ulaznice_UlaznicaID",
                        column: x => x.UlaznicaID,
                        principalTable: "Ulaznice",
                        principalColumn: "UlaznicaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    NotifikacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    IsProcitano = table.Column<bool>(nullable: false),
                    ObavijestID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacije", x => x.NotifikacijaID);
                    table.ForeignKey(
                        name: "FK_Notifikacije_Obavijesti_ObavijestID",
                        column: x => x.ObavijestID,
                        principalTable: "Obavijesti",
                        principalColumn: "ObavijestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_ObavijestID",
                table: "Notifikacije",
                column: "ObavijestID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_UlaznicaID",
                table: "Uplate",
                column: "UlaznicaID");
        }
    }
}
