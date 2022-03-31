using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectifEFCore.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Annee",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "MainActor", "Realisator", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Science-Fiction", "Mark Hammil", "Georges Lucas", 1977, "Star Wars : Un nouvel espoir" },
                    { 2, "Science-Fiction", "Mark Hammil", "Georges Lucas", 1980, "Star Wars : L'empire contre-attaque" },
                    { 3, "Science-Fiction", "Mark Hammil", "Georges Lucas", 1983, "Star Wars : Le retour du Jedi" },
                    { 4, "Société", "Charlie Hunnam", "Lexi Alexander", 2005, "Hooligans" },
                    { 5, "Heroic-Fantasy", "Elijah Wood", "Peter Jackson", 2001, "LOTR - La communauté de l'anneau" },
                    { 6, "Heroic-Fantasy", "Elijah Wood", "Peter Jackson", 2002, "LOTR - Les deux tours" },
                    { 7, "Heroic-Fantasy", "Elijah Wood", "Peter Jackson", 2003, "LOTR - Le retour du roi" }
                });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Annee",
                table: "Movies",
                sql: "ReleaseYear > 1975");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Annee",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddCheckConstraint(
                name: "CK_Annee",
                table: "Movies",
                sql: "YEAR(ReleaseDate) > 1975");
        }
    }
}
