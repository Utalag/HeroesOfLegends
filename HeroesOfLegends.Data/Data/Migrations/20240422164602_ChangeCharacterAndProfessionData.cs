using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCharacterAndProfessionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agility_bool",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "AtributeConfigBool",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Charisma_bool",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Constitution_bool",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Intelligence_bool",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Strength_bool",
                table: "Professions");

            migrationBuilder.RenameColumn(
                name: "StrengthPrimarPointed",
                table: "Characters",
                newName: "St_Primar");

            migrationBuilder.RenameColumn(
                name: "StrengthDiceRoll",
                table: "Characters",
                newName: "St_DiceRoll");

            migrationBuilder.RenameColumn(
                name: "IntelligencePrimarPointed",
                table: "Characters",
                newName: "In_Primar");

            migrationBuilder.RenameColumn(
                name: "IntelligenceDiceRoll",
                table: "Characters",
                newName: "In_DiceRoll");

            migrationBuilder.RenameColumn(
                name: "ConstitutionPrimarPointed",
                table: "Characters",
                newName: "Co_Primar");

            migrationBuilder.RenameColumn(
                name: "ConstitutionDiceRoll",
                table: "Characters",
                newName: "Co_DiceRoll");

            migrationBuilder.RenameColumn(
                name: "CharismaPrimarPointed",
                table: "Characters",
                newName: "Cha_Primar");

            migrationBuilder.RenameColumn(
                name: "CharismaDiceRoll",
                table: "Characters",
                newName: "Cha_DiceRoll");

            migrationBuilder.RenameColumn(
                name: "AgilityPrimarPointed",
                table: "Characters",
                newName: "Ag_Primar");

            migrationBuilder.RenameColumn(
                name: "AgilityDiceRoll",
                table: "Characters",
                newName: "Ag_DiceRoll");

            migrationBuilder.AddColumn<bool>(
                name: "Ag_bool",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cha_bool",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Con_bool",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Int_bool",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "St_bool",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ag_Primar", "Ag_bool", "Agility", "Cha_bool", "Charisma", "Co_Primar", "Con_bool", "In_Primar", "Int_bool", "Intelligence", "St_Primar", "St_bool", "Strength" },
                values: new object[] { 2, true, 0, false, 0, 2, false, 2, false, 0, 2, true, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ag_bool",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Cha_bool",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Con_bool",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Int_bool",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "St_bool",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "St_Primar",
                table: "Characters",
                newName: "StrengthPrimarPointed");

            migrationBuilder.RenameColumn(
                name: "St_DiceRoll",
                table: "Characters",
                newName: "StrengthDiceRoll");

            migrationBuilder.RenameColumn(
                name: "In_Primar",
                table: "Characters",
                newName: "IntelligencePrimarPointed");

            migrationBuilder.RenameColumn(
                name: "In_DiceRoll",
                table: "Characters",
                newName: "IntelligenceDiceRoll");

            migrationBuilder.RenameColumn(
                name: "Co_Primar",
                table: "Characters",
                newName: "ConstitutionPrimarPointed");

            migrationBuilder.RenameColumn(
                name: "Co_DiceRoll",
                table: "Characters",
                newName: "ConstitutionDiceRoll");

            migrationBuilder.RenameColumn(
                name: "Cha_Primar",
                table: "Characters",
                newName: "CharismaPrimarPointed");

            migrationBuilder.RenameColumn(
                name: "Cha_DiceRoll",
                table: "Characters",
                newName: "CharismaDiceRoll");

            migrationBuilder.RenameColumn(
                name: "Ag_Primar",
                table: "Characters",
                newName: "AgilityPrimarPointed");

            migrationBuilder.RenameColumn(
                name: "Ag_DiceRoll",
                table: "Characters",
                newName: "AgilityDiceRoll");

            migrationBuilder.AddColumn<bool>(
                name: "Agility_bool",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AtributeConfigBool",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Charisma_bool",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Constitution_bool",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Intelligence_bool",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Strength_bool",
                table: "Professions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Agility", "AgilityPrimarPointed", "Charisma", "ConstitutionPrimarPointed", "Intelligence", "IntelligencePrimarPointed", "Strength", "StrengthPrimarPointed" },
                values: new object[] { 4, 0, 4, 0, 4, 0, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 1,
                columns: new[] { "Agility_bool", "AtributeConfigBool", "Charisma_bool", "Constitution_bool", "Intelligence_bool", "Strength_bool" },
                values: new object[] { false, "[true,true]", false, true, false, true });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 2,
                columns: new[] { "Agility_bool", "AtributeConfigBool", "Charisma_bool", "Constitution_bool", "Intelligence_bool", "Strength_bool" },
                values: new object[] { false, "[true,true]", false, false, true, true });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 3,
                columns: new[] { "Agility_bool", "AtributeConfigBool", "Charisma_bool", "Constitution_bool", "Intelligence_bool", "Strength_bool" },
                values: new object[] { true, "[true,true]", false, true, false, false });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 4,
                columns: new[] { "Agility_bool", "AtributeConfigBool", "Charisma_bool", "Constitution_bool", "Intelligence_bool", "Strength_bool" },
                values: new object[] { false, "[true,true]", true, false, true, false });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 5,
                columns: new[] { "Agility_bool", "AtributeConfigBool", "Charisma_bool", "Constitution_bool", "Intelligence_bool", "Strength_bool" },
                values: new object[] { true, "[true,true]", true, false, false, false });
        }
    }
}
