using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SNDI.Migrations
{
    public partial class secondMigrationSNDI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enregistrer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FiliationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enregistrer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enregistrer_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Enregistrer_Filiation_FiliationId",
                        column: x => x.FiliationId,
                        principalTable: "Filiation",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enregistrer_DocumentId",
                table: "Enregistrer",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Enregistrer_FiliationId",
                table: "Enregistrer",
                column: "FiliationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enregistrer");
        }
    }
}
