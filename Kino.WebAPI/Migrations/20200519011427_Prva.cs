using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Prva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    BrojTokena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    ObavijestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Tekst = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.ObavijestID);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SalaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    BrojRedova = table.Column<int>(nullable: false),
                    BrojKolona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SalaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Zanrovi",
                columns: table => new
                {
                    ZanrID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanrovi", x => x.ZanrID);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    NotifikacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ObavijestID = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    IsProcitano = table.Column<bool>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Sjedista",
                columns: table => new
                {
                    SjedisteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Red = table.Column<int>(nullable: false),
                    Kolona = table.Column<int>(nullable: false),
                    Rezervisano = table.Column<bool>(nullable: false),
                    SalaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sjedista", x => x.SjedisteID);
                    table.ForeignKey(
                        name: "FK_Sjedista_Sale_SalaID",
                        column: x => x.SalaID,
                        principalTable: "Sale",
                        principalColumn: "SalaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UlogaID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filmovi",
                columns: table => new
                {
                    FilmID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ZanrID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Reziser = table.Column<string>(nullable: true),
                    Trajanje = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmovi", x => x.FilmID);
                    table.ForeignKey(
                        name: "FK_Filmovi_Zanrovi_ZanrID",
                        column: x => x.ZanrID,
                        principalTable: "Zanrovi",
                        principalColumn: "ZanrID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ocjena = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    FilmID = table.Column<int>(nullable: false)
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
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projekcije",
                columns: table => new
                {
                    ProjekcijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    SalaID = table.Column<int>(nullable: false),
                    FilmID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcije", x => x.ProjekcijaID);
                    table.ForeignKey(
                        name: "FK_Projekcije_Filmovi_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projekcije_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projekcije_Sale_SalaID",
                        column: x => x.SalaID,
                        principalTable: "Sale",
                        principalColumn: "SalaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ulaznice",
                columns: table => new
                {
                    UlaznicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumKupovine = table.Column<DateTime>(nullable: false),
                    SjedisteID = table.Column<int>(nullable: false),
                    ProjekcijaID = table.Column<int>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    BarCodeIMG = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulaznice", x => x.UlaznicaID);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Kupci_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Projekcije_ProjekcijaID",
                        column: x => x.ProjekcijaID,
                        principalTable: "Projekcije",
                        principalColumn: "ProjekcijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Sjedista_SjedisteID",
                        column: x => x.SjedisteID,
                        principalTable: "Sjedista",
                        principalColumn: "SjedisteID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UlaznicaID = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: false),
                    Popust = table.Column<decimal>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Filmovi_ZanrID",
                table: "Filmovi",
                column: "ZanrID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_ObavijestID",
                table: "Notifikacije",
                column: "ObavijestID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_FilmID",
                table: "Ocjene",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KupacID",
                table: "Ocjene",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_FilmID",
                table: "Projekcije",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_KorisnikID",
                table: "Projekcije",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_SalaID",
                table: "Projekcije",
                column: "SalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sjedista_SalaID",
                table: "Sjedista",
                column: "SalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_KupacID",
                table: "Ulaznice",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_ProjekcijaID",
                table: "Ulaznice",
                column: "ProjekcijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_SjedisteID",
                table: "Ulaznice",
                column: "SjedisteID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_UlaznicaID",
                table: "Uplate",
                column: "UlaznicaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.DropTable(
                name: "Ulaznice");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Projekcije");

            migrationBuilder.DropTable(
                name: "Sjedista");

            migrationBuilder.DropTable(
                name: "Filmovi");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Zanrovi");
        }
    }
}
