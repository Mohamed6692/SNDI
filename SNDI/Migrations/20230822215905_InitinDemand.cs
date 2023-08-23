using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations
{
    public partial class InitinDemand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DemandeInit",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeActAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroRecuPaiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreCopie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataRequet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnregistrerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandeInit", x => x.id);
                    table.ForeignKey(
                        name: "FK_DemandeInit_Enregistrer_EnregistrerId",
                        column: x => x.EnregistrerId,
                        principalTable: "Enregistrer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemandeInit_EnregistrerId",
                table: "DemandeInit",
                column: "EnregistrerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemandeInit");
        }
    }
}
