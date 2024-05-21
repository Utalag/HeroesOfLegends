using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMOdelReferencNarrativeProfession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professions_Naratives_NarrativeId",
                table: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_Professions_NarrativeId",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "NarrativId",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "NarrativeId",
                table: "Professions");

            migrationBuilder.CreateTable(
                name: "NarrativeProfession",
                columns: table => new
                {
                    NarrativesId = table.Column<int>(type: "int", nullable: false),
                    ProfessionsProfessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarrativeProfession", x => new { x.NarrativesId, x.ProfessionsProfessionId });
                    table.ForeignKey(
                        name: "FK_NarrativeProfession_Naratives_NarrativesId",
                        column: x => x.NarrativesId,
                        principalTable: "Naratives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NarrativeProfession_Professions_ProfessionsProfessionId",
                        column: x => x.ProfessionsProfessionId,
                        principalTable: "Professions",
                        principalColumn: "ProfessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NarrativeProfession_ProfessionsProfessionId",
                table: "NarrativeProfession",
                column: "ProfessionsProfessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NarrativeProfession");

            migrationBuilder.AddColumn<int>(
                name: "NarrativId",
                table: "Professions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NarrativeId",
                table: "Professions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 1,
                columns: new[] { "NarrativId", "NarrativeId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 2,
                columns: new[] { "NarrativId", "NarrativeId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 3,
                columns: new[] { "NarrativId", "NarrativeId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 4,
                columns: new[] { "NarrativId", "NarrativeId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 5,
                columns: new[] { "NarrativId", "NarrativeId" },
                values: new object[] { 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_Professions_NarrativeId",
                table: "Professions",
                column: "NarrativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professions_Naratives_NarrativeId",
                table: "Professions",
                column: "NarrativeId",
                principalTable: "Naratives",
                principalColumn: "Id");
        }
    }
}
