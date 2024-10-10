using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroesOfLegends.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProfession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Professions_ProfessionId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Naratives_Worlds_WorldId",
                table: "Naratives");

            migrationBuilder.DropForeignKey(
                name: "FK_NarrativeProfession_Naratives_NarrativesId",
                table: "NarrativeProfession");

            migrationBuilder.DropForeignKey(
                name: "FK_NarrativeProfession_Professions_ProfessionsProfessionId",
                table: "NarrativeProfession");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceWorld_Races_RacesRaceId",
                table: "RaceWorld");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceWorld_Worlds_WorldsId",
                table: "RaceWorld");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ProfessionId",
                table: "Characters");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Naratives_Worlds_WorldId",
                table: "Naratives",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarrativeProfession_Naratives_NarrativesId",
                table: "NarrativeProfession",
                column: "NarrativesId",
                principalTable: "Naratives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarrativeProfession_Professions_ProfessionsProfessionId",
                table: "NarrativeProfession",
                column: "ProfessionsProfessionId",
                principalTable: "Professions",
                principalColumn: "ProfessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceWorld_Races_RacesRaceId",
                table: "RaceWorld",
                column: "RacesRaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceWorld_Worlds_WorldsId",
                table: "RaceWorld",
                column: "WorldsId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Naratives_Worlds_WorldId",
                table: "Naratives");

            migrationBuilder.DropForeignKey(
                name: "FK_NarrativeProfession_Naratives_NarrativesId",
                table: "NarrativeProfession");

            migrationBuilder.DropForeignKey(
                name: "FK_NarrativeProfession_Professions_ProfessionsProfessionId",
                table: "NarrativeProfession");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceWorld_Races_RacesRaceId",
                table: "RaceWorld");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceWorld_Worlds_WorldsId",
                table: "RaceWorld");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProfessionId",
                table: "Characters",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Professions_ProfessionId",
                table: "Characters",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "ProfessionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Naratives_Worlds_WorldId",
                table: "Naratives",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NarrativeProfession_Naratives_NarrativesId",
                table: "NarrativeProfession",
                column: "NarrativesId",
                principalTable: "Naratives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NarrativeProfession_Professions_ProfessionsProfessionId",
                table: "NarrativeProfession",
                column: "ProfessionsProfessionId",
                principalTable: "Professions",
                principalColumn: "ProfessionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceWorld_Races_RacesRaceId",
                table: "RaceWorld",
                column: "RacesRaceId",
                principalTable: "Races",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceWorld_Worlds_WorldsId",
                table: "RaceWorld",
                column: "WorldsId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
