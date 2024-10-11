using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HeroesOfLegends.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfessionSkillClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    SkillClass = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "CreateByUserName", "Description", "Level", "Name", "SkillClass" },
                values: new object[,]
                {
                    { 1, "Admin", "Mastery in sword fighting.", 5, "Swordsmanship", 0 },
                    { 2, "Admin", "Skilled in using bows and arrows.", 4, "Archery", 2 },
                    { 3, "Admin", "Ability to create potions and elixirs.", 3, "Alchemy", 3 },
                    { 4, "Admin", "Control over fire spells.", 4, "Fire Magic", 1 },
                    { 5, "Admin", "Expertise in moving unseen.", 3, "Stealth", 0 },
                    { 6, "Admin", "Ability to heal wounds and injuries.", 2, "Healing", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
