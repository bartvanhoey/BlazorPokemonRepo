using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPokemon.Api.Migrations
{
    public partial class UpdatePokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Pokemons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pokemons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Pokemons");
        }
    }
}
