using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Ocjene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Filmovi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Filmovi");
        }
    }
}
