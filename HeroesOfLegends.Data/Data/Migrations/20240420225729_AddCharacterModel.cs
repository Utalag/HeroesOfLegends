using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Strength_boolTest",
                table: "Professions");

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    StrengthPrimarPointed = table.Column<int>(type: "int", nullable: false),
                    AgilityPrimarPointed = table.Column<int>(type: "int", nullable: false),
                    ConstitutionPrimarPointed = table.Column<int>(type: "int", nullable: false),
                    IntelligencePrimarPointed = table.Column<int>(type: "int", nullable: false),
                    CharismaPrimarPointed = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "ProfessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Agility", "AgilityPrimarPointed", "Charisma", "CharismaPrimarPointed", "Constitution", "ConstitutionPrimarPointed", "Description", "Intelligence", "IntelligencePrimarPointed", "Name", "ProfessionId", "Strength", "StrengthPrimarPointed" },
                values: new object[] { 1, 0, 0, 0, 0, 0, 0, "Drobný hobit pocházející z Kraje za Hvozdem.", 0, 0, "Bilbo Pytlík", 1, 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProfessionId",
                table: "Characters",
                column: "ProfessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.AddColumn<bool>(
                name: "Strength_boolTest",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 1,
                column: "Strength_boolTest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 2,
                column: "Strength_boolTest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 3,
                column: "Strength_boolTest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 4,
                column: "Strength_boolTest",
                value: false);

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 5,
                column: "Strength_boolTest",
                value: false);
        }
    }
}
