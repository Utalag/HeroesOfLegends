using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class AtributeConfigBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AtributeConfigBool",
                table: "Professions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "AtributeConfigBool", "Strength_boolTest" },
                values: new object[] { "[true,true]", false });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 2,
                columns: new[] { "AtributeConfigBool", "Strength_boolTest" },
                values: new object[] { "[true,true]", false });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 3,
                columns: new[] { "AtributeConfigBool", "Strength_boolTest" },
                values: new object[] { "[true,true]", false });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 4,
                columns: new[] { "AtributeConfigBool", "Strength_boolTest" },
                values: new object[] { "[true,true]", false });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 5,
                columns: new[] { "AtributeConfigBool", "Strength_boolTest" },
                values: new object[] { "[true,true]", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtributeConfigBool",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Strength_boolTest",
                table: "Professions");
        }
    }
}
