using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations.Auth
{
    public partial class InitialMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrePassGeneratenom",
                table: "AspNetUsers",
                newName: "PassGenerate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassGenerate",
                table: "AspNetUsers",
                newName: "PrePassGeneratenom");
        }
    }
}
