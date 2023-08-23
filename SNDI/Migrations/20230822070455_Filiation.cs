using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations
{
    public partial class Filiation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateeditionMere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateeditionPere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LieuxEditionMere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LieuxEditionPere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroPieceMere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroPiecePere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeDePiecesMere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeDePiecesPere",
                table: "Filiation",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateeditionMere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "DateeditionPere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "LieuxEditionMere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "LieuxEditionPere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "NumeroPieceMere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "NumeroPiecePere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "TypeDePiecesMere",
                table: "Filiation");

            migrationBuilder.DropColumn(
                name: "TypeDePiecesPere",
                table: "Filiation");
        }
    }
}
