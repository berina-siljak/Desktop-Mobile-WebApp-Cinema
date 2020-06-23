using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Sjedista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolona",
                table: "Sjedista");

            migrationBuilder.DropColumn(
                name: "Red",
                table: "Sjedista");

            migrationBuilder.AddColumn<string>(
                name: "Oznaka",
                table: "Sjedista",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oznaka",
                table: "Sjedista");

            migrationBuilder.AddColumn<int>(
                name: "Kolona",
                table: "Sjedista",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Red",
                table: "Sjedista",
                nullable: false,
                defaultValue: 0);
        }
    }
}
