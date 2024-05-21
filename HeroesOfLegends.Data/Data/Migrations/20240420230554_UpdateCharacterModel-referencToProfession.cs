using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCharacterModelreferencToProfession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                column: "RaceId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Characters");
        }
    }
}
