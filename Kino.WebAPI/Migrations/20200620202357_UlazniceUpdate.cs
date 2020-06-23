using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class UlazniceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CijenaSaPopustom",
                table: "Ulaznice",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Popust",
                table: "Ulaznice",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CijenaSaPopustom",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "Popust",
                table: "Ulaznice");
        }
    }
}
