using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCharacter2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgilityDiceRoll",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharismaDiceRoll",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConstitutionDiceRoll",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceDiceRoll",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StrengthDiceRoll",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Agility", "AgilityDiceRoll", "Charisma", "CharismaDiceRoll", "ConstitutionDiceRoll", "Intelligence", "IntelligenceDiceRoll", "Strength", "StrengthDiceRoll" },
                values: new object[] { 4, 4, 4, 4, 4, 4, 4, 4, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgilityDiceRoll",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharismaDiceRoll",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ConstitutionDiceRoll",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IntelligenceDiceRoll",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StrengthDiceRoll",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Agility", "Charisma", "Intelligence", "Strength" },
                values: new object[] { 0, 0, 0, 0 });
        }
    }
}
