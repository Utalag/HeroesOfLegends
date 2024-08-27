using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroesOfLegends.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfessionRangeAtributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrimaryAgility",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryCharisma",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryConstitution",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryIntelligence",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryStrength",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 1,
                columns: new[] { "PrimaryAgility", "PrimaryCharisma", "PrimaryConstitution", "PrimaryIntelligence", "PrimaryStrength" },
                values: new object[] { "[12,13,14]", "[12,13]", "[12,13]", "[12,13,14]", "[11,12,13]" });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 2,
                columns: new[] { "PrimaryAgility", "PrimaryCharisma", "PrimaryConstitution", "PrimaryIntelligence", "PrimaryStrength" },
                values: new object[] { "[12,13,14]", "[12,13]", "[12,13]", "[12,13,14]", "[11,12,13]" });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 3,
                columns: new[] { "PrimaryAgility", "PrimaryCharisma", "PrimaryConstitution", "PrimaryIntelligence", "PrimaryStrength" },
                values: new object[] { "[12,13,14]", "[12,13]", "[12,13]", "[12,13,14]", "[11,12,13]" });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 4,
                columns: new[] { "PrimaryAgility", "PrimaryCharisma", "PrimaryConstitution", "PrimaryIntelligence", "PrimaryStrength" },
                values: new object[] { "[12,13,14]", "[12,13]", "[12,13]", "[12,13,14]", "[11,12,13]" });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 5,
                columns: new[] { "PrimaryAgility", "PrimaryCharisma", "PrimaryConstitution", "PrimaryIntelligence", "PrimaryStrength" },
                values: new object[] { "[12,13,14]", "[12,13]", "[12,13]", "[12,13,14]", "[11,12,13]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryAgility",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "PrimaryCharisma",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "PrimaryConstitution",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "PrimaryIntelligence",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "PrimaryStrength",
                table: "Professions");
        }
    }
}
