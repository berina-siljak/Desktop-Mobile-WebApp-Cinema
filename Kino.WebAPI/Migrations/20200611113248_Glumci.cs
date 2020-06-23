using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Glumci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oznaka",
                table: "Sjedista");

            migrationBuilder.DropColumn(
                name: "Rezervisano",
                table: "Sjedista");

            migrationBuilder.RenameColumn(
                name: "Red",
                table: "Sjedista",
                newName: "OznakaReda");

            migrationBuilder.AddColumn<int>(
                name: "OznakaKolone",
                table: "Sjedista",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Glumci",
                table: "Filmovi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GodinaIzdavanja",
                table: "Filmovi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OznakaKolone",
                table: "Sjedista");

            migrationBuilder.DropColumn(
                name: "Glumci",
                table: "Filmovi");

            migrationBuilder.DropColumn(
                name: "GodinaIzdavanja",
                table: "Filmovi");

            migrationBuilder.RenameColumn(
                name: "OznakaReda",
                table: "Sjedista",
                newName: "Red");

            migrationBuilder.AddColumn<string>(
                name: "Oznaka",
                table: "Sjedista",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Rezervisano",
                table: "Sjedista",
                nullable: false,
                defaultValue: false);
        }
    }
}
