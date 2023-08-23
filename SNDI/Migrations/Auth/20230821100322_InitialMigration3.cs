using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations.Auth
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrePassGeneratenom",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrePassGeneratenom",
                table: "AspNetUsers");
        }
    }
}
