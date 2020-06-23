using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kino.WebAPI.Migrations
{
    public partial class Cijena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ulaznice_Kupci_KupacID",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "Vrijeme",
                table: "Ulaznice");

            migrationBuilder.AlterColumn<int>(
                name: "KupacID",
                table: "Ulaznice",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<decimal>(
                name: "Cijena",
                table: "Projekcije",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Ulaznice_Kupci_KupacID",
                table: "Ulaznice",
                column: "KupacID",
                principalTable: "Kupci",
                principalColumn: "KupacID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ulaznice_Kupci_KupacID",
                table: "Ulaznice");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Projekcije");

            migrationBuilder.AlterColumn<int>(
                name: "KupacID",
                table: "Ulaznice",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Vrijeme",
                table: "Ulaznice",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Ulaznice_Kupci_KupacID",
                table: "Ulaznice",
                column: "KupacID",
                principalTable: "Kupci",
                principalColumn: "KupacID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
