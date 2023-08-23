using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations
{
    public partial class Demande2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Montant",
                table: "DemandeInit",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Montant",
                table: "DemandeInit");
        }
    }
}
