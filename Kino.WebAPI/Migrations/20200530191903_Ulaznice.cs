using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Ulaznice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatumKupovine",
                table: "Ulaznice",
                newName: "Vrijeme");

            migrationBuilder.AddColumn<DateTime>(
                name: "Datum",
                table: "Ulaznice",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Red",
                table: "Sjedista",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datum",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "Red",
                table: "Sjedista");

            migrationBuilder.RenameColumn(
                name: "Vrijeme",
                table: "Ulaznice",
                newName: "DatumKupovine");
        }
    }
}
