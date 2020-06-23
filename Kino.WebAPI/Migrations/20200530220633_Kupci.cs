using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Kupci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Kupci");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Kupci");

            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "Kupci");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Kupci",
                newName: "KupacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KupacID",
                table: "Kupci",
                newName: "KorisnikID");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Kupci",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Kupci",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDate",
                table: "Kupci",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
