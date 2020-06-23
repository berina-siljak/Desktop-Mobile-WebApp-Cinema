using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Druga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BrojRedova",
                table: "Sale",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "BrojKolona",
                table: "Sale",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BrojRedova",
                table: "Sale",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrojKolona",
                table: "Sale",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
