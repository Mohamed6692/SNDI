using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Circonscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LieuxEtablissement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomDeFamille = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomDeJeuneFille = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituationMatrimoniale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreEnfant = table.Column<int>(type: "int", nullable: true),
                    DateDenaissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LieuxNaissance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaysNaissance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationnalite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneDeNaissance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDeTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domicile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeDepiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDePiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEdition = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Filiation",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomPere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrenomPere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDenaissancePere = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LieuxNaissancePere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomMere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrenomMere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDenaissanceMere = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LieuxNaissanceMere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiation", x => x.id);
                    table.ForeignKey(
                        name: "FK_Filiation_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filiation_DocumentId",
                table: "Filiation",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filiation");

            migrationBuilder.DropTable(
                name: "Document");
        }
    }
}
