using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroesOfLegends.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewHealingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 1,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 2 Hp za 1 směnu, maximálně 2 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 2,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 4 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 3,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 6 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 4,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 8 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 5,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 10 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 6,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 12 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 7,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 14 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 8,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 16 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 9,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 4 Hp za 1 směnu, maximálně 16 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 10,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 4 Hp za 1 směnu, maximálně 16 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 11,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 5 Hp za 1 směnu, maximálně 16 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 12,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 6 Hp za 1 směnu, maximálně 16 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 1 Hp za 1 směnu, maximálně 1 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 14,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 2 Hp za 1 směnu, maximálně 2 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 15,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 3 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 16,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 4 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 17,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 5 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 18,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 6 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 19,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 7 Hp za den.");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 20,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 Hp za 1 směnu, maximálně 8 Hp za den.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 1,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 2 za 2 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 2,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 4 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 3,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 6 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 4,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 8 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 5,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 10 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 6,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 12 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 7,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 14 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 8,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 16 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 9,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 16 za 4 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 10,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 16 za 4 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 11,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 16 za 5 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 12,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 16 za 6 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 1 za 1 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 14,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 2 za 2 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 15,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 3 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 16,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 4 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 17,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 5 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 18,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 6 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 19,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 7 za 3 směn/y životů");

            migrationBuilder.UpdateData(
                table: "SpecificSkill",
                keyColumn: "Id",
                keyValue: 20,
                column: "SpecificDescription",
                value: "Postava si může vyléčit 8 za 3 směn/y životů");
        }
    }
}
