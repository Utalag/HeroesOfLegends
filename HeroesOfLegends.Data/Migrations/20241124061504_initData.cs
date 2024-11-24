using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HeroesOfLegends.Data.Migrations
{
    /// <inheritdoc />
    public partial class initData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    Strengt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Constitution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intelligence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charisma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profipoints = table.Column<int>(type: "int", nullable: false),
                    PrimaryAtribut_1 = table.Column<int>(type: "int", nullable: false),
                    PrimaryAtribut_2 = table.Column<int>(type: "int", nullable: false),
                    PrimarValueIndex_1 = table.Column<int>(type: "int", nullable: false),
                    PrimarValueIndex_2 = table.Column<int>(type: "int", nullable: false),
                    StrengthFinalRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgilityFinalRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstitutionFinalRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntelligenceFinalRange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharismaFinalRange = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    HpRangeMin = table.Column<int>(type: "int", nullable: false),
                    HpRangeMax = table.Column<int>(type: "int", nullable: false),
                    WizardMana = table.Column<int>(type: "int", nullable: false),
                    HasWizardMana = table.Column<bool>(type: "bit", nullable: false),
                    RengerMana = table.Column<int>(type: "int", nullable: false),
                    HasRengerMana = table.Column<bool>(type: "bit", nullable: false),
                    AlchemiMana = table.Column<int>(type: "int", nullable: false),
                    HasAlchemiMana = table.Column<bool>(type: "bit", nullable: false),
                    SpecialdMana = table.Column<int>(type: "int", nullable: false),
                    HasSpecialdMana = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KnowledgeGroup = table.Column<int>(type: "int", nullable: false),
                    SkillClass = table.Column<int>(type: "int", nullable: false),
                    ProfessionClass = table.Column<int>(type: "int", nullable: false),
                    DependencySkillId = table.Column<int>(type: "int", nullable: false),
                    DependencySkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseProfessionPoint = table.Column<int>(type: "int", nullable: false),
                    BaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatetByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionSkill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceSize = table.Column<int>(type: "int", nullable: false),
                    Mobility = table.Column<int>(type: "int", nullable: false),
                    SpecialAbilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialAbilitiesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightMin = table.Column<int>(type: "int", nullable: false),
                    WeightMax = table.Column<int>(type: "int", nullable: false),
                    BodyHeightMin = table.Column<int>(type: "int", nullable: false),
                    BodyHeightMax = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Strength_Max = table.Column<int>(type: "int", nullable: false),
                    Strength_Corection = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Agility_Max = table.Column<int>(type: "int", nullable: false),
                    Agility_Corection = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Constitution_Max = table.Column<int>(type: "int", nullable: false),
                    Constitution_Corection = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Intelligence_Max = table.Column<int>(type: "int", nullable: false),
                    Intelligence_Correction = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Charisma_Max = table.Column<int>(type: "int", nullable: false),
                    Charisma_Correction = table.Column<int>(type: "int", nullable: false),
                    Strength_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Dexterity_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Constitution_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Intelligence_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Charisma_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                });

            migrationBuilder.CreateTable(
                name: "Worlds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorldDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfMagicInTheWorld = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worlds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BindingProfessionsSkills",
                columns: table => new
                {
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    ProfessionSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BindingProfessionsSkills", x => new { x.ProfessionId, x.ProfessionSkillId });
                    table.ForeignKey(
                        name: "FK_BindingProfessionsSkills_ProfessionSkill_ProfessionSkillId",
                        column: x => x.ProfessionSkillId,
                        principalTable: "ProfessionSkill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BindingProfessionsSkills_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    InternalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecificDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillSumPrice = table.Column<int>(type: "int", nullable: false),
                    ProfessionClass = table.Column<int>(type: "int", nullable: false),
                    LevelGroup = table.Column<int>(type: "int", nullable: false),
                    ProfessionSkillId = table.Column<int>(type: "int", nullable: false),
                    Skill_type = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    MaxHealingPoints = table.Column<int>(type: "int", nullable: true),
                    SpeedOfHealing = table.Column<int>(type: "int", nullable: true),
                    Initiative = table.Column<int>(type: "int", nullable: true),
                    InitiativeText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryWeapon = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificSkill_ProfessionSkill_ProfessionSkillId",
                        column: x => x.ProfessionSkillId,
                        principalTable: "ProfessionSkill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Naratives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarrativeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NarrativeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Era = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    WorldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naratives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Naratives_Worlds_WorldId",
                        column: x => x.WorldId,
                        principalTable: "Worlds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceWorld",
                columns: table => new
                {
                    RacesRaceId = table.Column<int>(type: "int", nullable: false),
                    WorldsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceWorld", x => new { x.RacesRaceId, x.WorldsId });
                    table.ForeignKey(
                        name: "FK_RaceWorld_Races_RacesRaceId",
                        column: x => x.RacesRaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceWorld_Worlds_WorldsId",
                        column: x => x.WorldsId,
                        principalTable: "Worlds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarrativeProfession",
                columns: table => new
                {
                    NarrativesId = table.Column<int>(type: "int", nullable: false),
                    ProfessionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarrativeProfession", x => new { x.NarrativesId, x.ProfessionsId });
                    table.ForeignKey(
                        name: "FK_NarrativeProfession_Naratives_NarrativesId",
                        column: x => x.NarrativesId,
                        principalTable: "Naratives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarrativeProfession_Professions_ProfessionsId",
                        column: x => x.ProfessionsId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProfessionSkill",
                columns: new[] { "Id", "BaseDescription", "BaseProfessionPoint", "CreatetByUserName", "DependencySkillId", "DependencySkillName", "KnowledgeGroup", "ProfessionClass", "SkillClass", "SkillName" },
                values: new object[,]
                {
                    { 1, "", 2, "Admin", 0, "", 0, 1, 0, "Léčba vlastních zranění II" },
                    { 2, "", 1, "Admin", 0, "", 0, 1, 0, "Odhad soupeře" },
                    { 3, "", 1, "Admin", 0, "", 0, 1, 0, "Odhad zbraně" },
                    { 4, "", 1, "Admin", 0, "", 0, 1, 0, "Poznání artefaktu" },
                    { 5, "", 2, "Admin", 0, "", 0, 1, 0, "Přesnost" },
                    { 6, "", 1, "Admin", 0, "", 0, 1, 0, "Sehranost" },
                    { 7, "", 4, "Admin", 0, "", 0, 1, 0, "Vícenásobné útoky" },
                    { 8, "", 1, "Admin", 0, "", 0, 1, 0, "Zastrašení" },
                    { 9, "", 1, "Admin", 0, "", 0, 8, 2, "Boj se zvýřaty" },
                    { 10, "", 2, "Admin", 0, "", 0, 8, 2, "Stopování" },
                    { 11, "", 2, "Admin", 0, "", 0, 8, 1, "Hraničářská mana" },
                    { 12, "", 3, "Admin", 12, "", 0, 8, 1, "Kouzla" },
                    { 13, "", 4, "Admin", 0, "", 0, 8, 1, "Mymosmysloví schopnosti" },
                    { 14, "", 2, "Admin", 12, "", 0, 8, 1, "Zmámení" },
                    { 15, "", 2, "Admin", 0, "", 0, 8, 2, "Pes" },
                    { 16, "", 1, "Admin", 0, "", 0, 11, 3, "Odolnost proti jedům" },
                    { 17, "", 1, "Admin", 0, "", 0, 11, 3, "Lučba a magenergie" },
                    { 18, "", 3, "Admin", 17, "", 0, 11, 3, "Lektvary" },
                    { 19, "", 1, "Admin", 17, "", 0, 11, 3, "Svitky" },
                    { 20, "", 1, "Admin", 17, "", 0, 11, 3, "Ostatní" },
                    { 21, "", 1, "Admin", 17, "", 0, 11, 3, "Zbraně" },
                    { 22, "", 1, "Admin", 17, "", 0, 11, 3, "Prsteny" },
                    { 23, "", 3, "Admin", 17, "", 0, 11, 3, "Jedy" },
                    { 24, "", 3, "Admin", 17, "", 0, 11, 3, "Výbušniny" },
                    { 25, "", 2, "Admin", 26, "", 0, 5, 1, "Kouzelnický přítel" },
                    { 26, "", 4, "Admin", 0, "", 0, 5, 1, "Kouzelnická magenergie" },
                    { 27, "", 2, "Admin", 26, "", 0, 5, 1, "Časoprostorová magie" },
                    { 28, "", 1, "Admin", 26, "", 0, 5, 1, "Energetická útočná magie" },
                    { 29, "", 1, "Admin", 26, "", 0, 5, 1, "Energetická obranná magie" },
                    { 30, "", 1, "Admin", 26, "", 0, 5, 1, "Materiální magie" },
                    { 31, "", 1, "Admin", 26, "", 0, 5, 1, "Vitální magie" },
                    { 32, "", 1, "Admin", 26, "", 0, 5, 1, "Psychická magie" },
                    { 33, "", 1, "Admin", 26, "", 0, 5, 1, "Poznávací magie" },
                    { 34, "", 1, "Admin", 26, "", 0, 5, 1, "Iluzivní magie" },
                    { 35, "", 2, "Admin", 0, "", 0, 14, 6, "Převleky" },
                    { 36, "", 1, "Admin", 0, "", 0, 14, 6, "Zisk důvěry" },
                    { 37, "", 1, "Admin", 0, "", 0, 14, 6, "Objevení mechanismu" },
                    { 38, "", 1, "Admin", 0, "", 0, 14, 6, "Objevení objektu" },
                    { 39, "", 2, "Admin", 0, "", 0, 14, 6, "Šplh po zdech" },
                    { 40, "", 1, "Admin", 0, "", 0, 14, 6, "Skok z výšky" },
                    { 41, "", 1, "Admin", 0, "", 0, 14, 6, "Tichý pohyb" },
                    { 42, "", 1, "Admin", 0, "", 0, 14, 6, "Schování se ve stínu" },
                    { 43, "", 1, "Admin", 0, "", 0, 14, 6, "Vybírání kapes" },
                    { 44, "", 1, "Admin", 0, "", 0, 14, 6, "Otevření objetu" },
                    { 45, "", 1, "Admin", 0, "", 0, 14, 6, "Zneškodnění mechanismu" },
                    { 46, "", 3, "Admin", 0, "", 0, 14, 0, "Probodnutí ze zálohy" },
                    { 47, "", 1, "Admin", 0, "", 0, 18, 0, "Léčba vlastních zranění I" },
                    { 48, "", 4, "Admin", 0, "", 0, 18, 0, "Vícenásobné útoky ve střelbě" },
                    { 49, "", 1, "Admin", 0, "", 0, 18, 0, "Zrak" },
                    { 50, "", 1, "Admin", 0, "", 0, 18, 0, "Odhad střelných zbraní" },
                    { 51, "", 1, "Admin", 0, "", 0, 18, 0, "Odhad soupeře" },
                    { 52, "", 5, "Admin", 0, "", 0, 18, 5, "Výroba šípů" },
                    { 53, "", 1, "Admin", 0, "", 0, 18, 0, "Krok a střelba" },
                    { 54, "", 1, "Admin", 0, "", 0, 0, 7, "Životy 1k6" },
                    { 55, "", 2, "Admin", 0, "", 0, 0, 7, "Životy 1k6+1" },
                    { 56, "", 3, "Admin", 0, "", 0, 0, 7, "Životy 1k6+2" },
                    { 57, "", 4, "Admin", 0, "", 0, 0, 7, "Životy 1k10" },
                    { 58, "", 1, "Admin", 0, "", 0, 0, 7, "Sum range 23-24" },
                    { 59, "", 2, "Admin", 0, "", 0, 0, 7, "Sum range 25" },
                    { 60, "", 3, "Admin", 0, "", 0, 0, 7, "Sum range 26" },
                    { 61, "", 4, "Admin", 0, "", 0, 0, 7, "Sum range 27-28" }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "AlchemiMana", "Description", "HasAlchemiMana", "HasRengerMana", "HasSpecialdMana", "HasWizardMana", "HpRangeMax", "HpRangeMin", "Level", "Name", "RengerMana", "SpecialdMana", "WizardMana" },
                values: new object[,]
                {
                    { 1, 0, "Zkušený bojovník, který se specializuje na zbraně a bojovou taktiku. Je fyzicky zdatný a často nosí těžké brnění. Válečníci vedou své spojence do bitvy a používají svou sílu a odvahu k ochraně ostatních. Jsou loajální a čestní, připravení postavit se jakékoli hrozbě.", false, false, false, false, 10, 1, 1, "Válečník", 0, 0, 0 },
                    { 2, 0, "Mistr magie, ovládající sílu živlů a starodávných kouzel. Často se věnuje studiu mystických textů a hledá tajemství ukrytá ve stínech. Kouzelníci jsou schopni léčit, klamat nepřátele nebo vytvářet ničivá kouzla. Jsou intelektuálně založení a často se spoléhají na svou moudrost a znalosti.", false, false, false, true, 6, 1, 1, "Kouzelník", 0, 0, 7 },
                    { 3, 9, "Vědec a badatel, který míchá elixíry a hledá tajemství transmutace. Alchymisté jsou známí svou schopností vytvářet léčivé lektvary, výbušniny a různé magické substance. Jejich práce často hraničí s tajemnem a někteří se snaží najít kámen mudrců. Je to povolání plné experimentů a objevů.", true, false, false, false, 8, 1, 1, "Alchymista", 0, 0, 0 },
                    { 4, 0, "Mistr lukostřelby a lovec, který se specializuje na střelbu z dálky. Lučištníci jsou rychlí a obratní, schopní zasáhnout nepřítele z velké vzdálenosti. Používají luky, kuše a střelné zbraně k ochraně svých spojenců a lovu zvěře. Jsou často samotáři a preferují život v divočině.", false, false, false, false, 8, 1, 1, "Lučištník", 0, 0, 0 },
                    { 5, 0, "Mistr lstí a skrytých operací, který se specializuje na krádeže a infiltraci. Je rychlý, tichý a vysoce obratný, což mu umožňuje snadno unikat nepřátelům. Zloději využívají své dovednosti k získávání informací a cenností. Jsou inteligentní a vynalézaví, často pracující ve stínu.", false, false, false, false, 6, 1, 1, "Zloděj", 0, 0, 0 },
                    { 6, 0, "Mistr přežití v divočině, který často slouží jako stopař a strážce. Má hluboké znalosti o přírodě a umí se pohybovat nepozorovaně. Hraničáři bývají vynikající lučištníci a lovci, kteří využívají svých dovedností k ochraně říše před nebezpečím. Spojují fyzickou zdatnost s bystrým instinktem.", false, true, false, false, 7, 1, 1, "Hraničář", 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "RaceId", "Agility", "Agility_Corection", "Agility_Max", "BodyHeightMax", "BodyHeightMin", "Charisma", "Charisma_Correction", "Charisma_DiceRoll", "Charisma_Max", "Constitution", "Constitution_Corection", "Constitution_DiceRoll", "Constitution_Max", "Dexterity_DiceRoll", "ImagePath", "Intelligence", "Intelligence_Correction", "Intelligence_DiceRoll", "Intelligence_Max", "Mobility", "RaceDescription", "RaceName", "RaceSize", "SpecialAbilities", "SpecialAbilitiesDescription", "Strength", "Strength_Corection", "Strength_DiceRoll", "Strength_Max", "WeightMax", "WeightMin" },
                values: new object[,]
                {
                    { 1, 11, 2, 16, 120, 70, 8, 3, 2, 18, 8, 0, 1, 13, 1, "~/Images/Race/hobbit.jpeg", 10, -2, 1, 15, 10, "Hobiti jsou malým, veselým nárůdkem. Jsou ještě menší než trpaslíci, chlupatí a jaksi \"dobrácky kulaťoučcí\". Žijí zpravidla v úrodných údolích, kde si ve stráních budují komfortní nory a doupata. Rozhodně nejsou nijak zvlášť silní, ale zato jsou velmi obratní a povětšinou inteligentní. Dobrodružství příliš nevyhledávají, protože mají rádi pohodlí, dobré jídlo a silné piti. Jestliže se však jednou přece jen vydají na cesty, patří k těm nejlepším zlodějům, jaké si jen dovedeš představit. Hobiti mají také zvláštní psychickou schopnost, díky které dokážou \"vycítit\" na dálku většinu živých tvorů. Této zvláštní vlastnosti říkají mezi sebou \"čich\", a přestože jejich pohodlnickým životem již dosti zakrněla, dokážou díky ní lokalizovat živou bytost, dokonce i když je od nich oddělena například železnou stěnou. Přestože hobiti nejsou zbabělí, jen neradi přistupují na boj tváří v tvář a raději používají své kuše než těžké meče nebo halapartny.", "Hobbit", 0, "Čich", "Tato schopnost mu umožňuje vycítit přítomnost většiny živých tvorů což zdaleka neznamená všechny tvory, například na kostlivce je hobitův čich krátký), není ale schopen vycítit různé plísně, houby a jiné rostliny ani běžné tvory velikosti A0 (respektive byl by schopen je cítit, ale nevnímá je, asi jako člověk obvykle nevnímá mravence v trávě, ačkoliv je schopen je vidět). Největší vzdálenost, na jakou to je schopen dokázat, je 12 sáhů. Tato vzdálenost se zkracuje o 1 sáh za každých 30 coulů dřeva, 10 coulů kamene nebo 1 coul kovu. Hobit není schopen určit, o jakého tvora se jedná, ani jak je přesně daleko, ale pozná, do jaké třídy velikosti patří. Hobit má neurčitý pocit cizí přítomnosti. Hobit nemůže svou zvláštní schopnost používat, pokud spí. V bdělém stavu se na ni nemusí soustředit, ale nebude-li svému okolí věnovat dostatečnou pozornost, může mu něco uniknout. Hobita při používání čichu neruší přítomnost ostatních členů družiny.", 3, -5, 1, 8, 60, 40 },
                    { 2, 10, 1, 15, 130, 90, 7, 0, 1, 12, 10, 1, 1, 15, 1, "~/Images/Race/gnom.jpeg", 9, -2, 1, 14, 9, "Gnómové jsou zvláštní rasou, o které se ví téměř jistě, že vznikla kdysi v dávných dobách splynutím části plemene trpaslíků s hobity. Podobně jako hobiti také gnómové jsou velmi obratní a poměrně chytří. Po trpaslících zase zdědili jejich nezdolnost a z části také lásku ke zlatu a drahým kamenům. Žijí v horách i v nížinách, ale nemilují podzemí, a proto si staví drobné kamenné domy, většinou daleko od velkých měst a obchodních cest. Přestože jen málokterý z nich se stane dobrým bojovníkem, dokážou v boji velmi dobře zacházet jak se sekerou, tak i s kuší. Mnoho z nich také nachází potěšení v různém bylinkářství a alchymii, ale stejně tak dobře se mohou uplatnit třeba jako zloději.", "Gnom", 0, "", "", 5, -3, 1, 10, 75, 50 },
                    { 3, 7, -2, 12, 140, 110, 7, -2, 1, 12, 12, 3, 1, 17, 1, "~/Images/Race/trpaslik.jpeg", 8, -3, 1, 13, 8, "Trpaslíci jsou jednou z nejznámějších člověku podobných ras. Jsou menší, podsadití, zocelení dlouhými věky strávenými v nehostinných pustinách. Jejich větrem ošlehané tváře snad vždy zdobí hnědé až černé vousy, které jim však, stejně jako vlasy, poměrně záhy šedivějí. Sídlí v horách, zpravidla daleko od civilizace. Díky infravidění vidí v omezené míře i ve tmě, a proto mohou pod zemí budovat rozsáhlé skalní komplexy šachet, jeskyní a sálů, kde těží drahé kameny, stříbro a především svoje milované zlato. Trpaslíci většinou postrádají jakýkoliv smysl pro humor, jsou vždy vážní a někdy až příliš sebejistí. Dané slovo dodrží, zejména kyne-li jim z toho nějaká výhoda. Jejich nejoblíbenější zbraní je válečná sekera. V boji jsou nesmírně stateční a jen neradi ustupují z prohrané bitvy. Brání-li trpaslík svoji hroudu zlata, neustoupí ani před rozvztekleným, vyhladovělým ohnivým drakem.", "Trpaslík", 0, "Infravidění", "Infravidění má dosah 20 sáhů a neproniká žádným materiálem, kterým by neproniklo obyčejné světlo. Ve slunečním světle (nebo ve světle stejné intenzity vyvolaném kouzlem) je infravidění nepoužitelné. Infravidění rovněž není použitelné za mlhy (a to ani ve tmě), podobně jako normální zrak. Pod vodou je infravidění použitelné, ale nikoli skrz vodní hladinu, která infrazáření podobně jako světlo a zvuk láme a všelijak zkresluje. Infravidění je schopnost vidět teplo. I v naprosté tmě trpaslík zřetelně uvidí každého živého tvora s teplou krví - skřeta i zatoulaného psa- jako jasně červenou skvrnu. Hady, červy a jiné studenokrevné živočichy trpaslík neuvidí, pokud se nebude dívat velmi pozorně. Infraviděním rovněž nelze zpozorovat některé nestvůry magické podstaty, jež nevydávají teplo (například kostlivce). lnfraviděním zpravidla nelze určovat ani tvar místností, ani jejich obsah. Výjimkou mohou být věci, které jsou studenější nebo teplejší než okolí. Například jezírko studené vody trpaslík uvidí jako tmavě modrou skvrnu, nedávno vyhaslé ohniště jako tmavě červenou. Trpaslík se nemusí na infravidění soustřeďovat. V situaci, kdy mu nebude stačit obyčejný zrak, začne automaticky infravidění využívat. I když tobě se takové zobrazení může zdát nejasné a nepochopitelné, trpaslík, který ho má jako vrozenou schopnost, se v něm poměrně dobře vyzná. Přechod od normálního vidění k infra vidění lze přirovnat k překrývání fotografií. Jakmile v šeru trpaslík přestává vidět skutečné barvy, začíná vnímat infrabarvy.", 7, 1, 1, 12, 100, 55 },
                    { 4, 10, 1, 15, 180, 145, 8, 2, 2, 18, 6, -4, 1, 11, 1, "~/Images/Race/elf.jpeg", 12, 2, 1, 17, 12, "Elfové jsou známou rasou, žijící zpravidla hluboko v lesích nebo odlehlých údolích a roklinách. Jsou menší než lidé a zdaleka ne tak robustní. Pro své většinou plavé vlasy a jemné rysy obličeje jsou pokládáni za velmi krásné až poněkud změkčilé. Protože jsou velmi inteligentní, jen neradi bojují avšak jsou-li k boji donuceni, mohou být nebezpečnými soupeři. Díky své obratnosti dovedou dobře zacházet zejména s lukem a se střelnými zbraněmi vůbec. Největší potěšeni jim však činí studium a učení se kouzlům, a proto z jejich řad vzešlo již mnoho známých kouzelníků. Také milují krásné věci, ale od trpaslíků (které mimochodem nemají příliš v lásce) se liší především tím, že krásu hned nepřepočítávají na zlaťáky. Elfové jsou vesměs velmi čestní a spravedliví a nikdy se mezi nimi nevyskytují jedinci, pro které by zlo bylo přirozenou podstatou jejich osobnosti.", "Elf", 1, "Dlouhověkost", "", 6, 0, 1, 11, 85, 50 },
                    { 5, 9, 0, 14, 210, 165, 2, 0, 3, 17, 9, 0, 1, 14, 1, "~/Images/Race/clovek.jpeg", 10, 0, 1, 15, 11, "Lidé jsou snad nejrozšířenější rasou, žijící jak v oblastech hor, tak i ve stepích, lesích a tundrách. Budují rozsáhlá sídla, ať už města či vesnice, která zpravidla leží na velkých obchodních křižovatkách. Lidé jsou velmi houževnatí, nacházejí uplatnění v celé škále povoláni. Většina z nich se zabývá především zemědělstvím a řemeslnou výrobou, ale najdete mezi nimi i zdatné lovce a zkušené dobrodruhy všeho druhu.", "Člověk", 1, "", "", 6, 0, 2, 16, 115, 65 },
                    { 6, 8, -1, 13, 220, 175, 1, -2, 3, 16, 11, 1, 1, 16, 1, "~/Images/Race/barbar.jpeg", 6, 0, 1, 11, 12, "Barbaři jsou v podstatě lidé, ale jejich po staletí trvající odloučení od skutečné lidské civilizace způsobilo, že barbar zpravidla není tak inteligentní jako člověk, avšak je silnější a mnohem odolnější. Tyto vlastnosti jej také předurčují k tomu, aby se stal dobrým válečníkem.", "Barbar", 1, "", "", 10, 1, 1, 15, 140, 75 },
                    { 7, 5, -4, 10, 245, 180, 1, -5, 2, 11, 13, 3, 1, 18, 1, "~/Images/Race/kroll.jpeg", 2, -6, 1, 7, 11, "Krollové sídlí v horách, tundrách a vůbec v prostředí velmi tvrdém a nehostinném. Dospělý kroll může měřit hodně přes dva metry a zjevem může vzdáleně (velmi vzdáleně) připomínat pračlověka, i když jeho kůže je spíše zrohovatělá než chlupatá. Bezpečně je však poznáte podle jejich nezaměnitelných uší, jimž vděčí za svůj neobvyklý sluch. Krollové jsou silnější než obyčejní lidé, ale také poněkud neohrabaní a zejména o poznání hloupější. Žijí obvykle v nevelkých kmenech, které mezi sebou neustále válčí. V těchto bojích se velmi zdokonalili, a proto nyní patří k nejobávanějším bojovníkům a z jejich kyjů a palcátů jde vskutku příslovečný strach. Po svých divokých předcích kromě jiného podědili také vrozený \"ultrasluch\", který jim umožňuje do jisté míry \"vidět\" (podobně jako netopýrům) i za úplné tmy nebo mlhy. Pokud jde o jejich původ, je možné, že vznikli kdysi dávno spojením skřeta s poloobrem. To by také vysvětlovalo, proč se mezi nimi téměř nikdy nevyskytují jedinci preferující výhradně dobro.", "Kroll", 2, "Ultrasluch", "Jeho zvláštní schopnost se nazývá ultrasluch a připomíná sonar netopýrů. Kroll je schopen vysílat Lidským uchem nezachytitelné zvukové vlnění, které se odráží od zkoumaného předmětu a vrací se zpět ke krollovi. Podle toho, jak odražené vlnění vypadá, je kroll schopen určit vzdálenost a tvar předmětu. Ultrasluch je použitelný v mlze, dokonce i pod vodou (ale ne skrz vodní hladinu, na ní se zvuk láme, odráží a všelijak zkresluje). Krollův ultrasluch má dosah 50 sáhů. To znamená, že kroll je schopen postřehnout jakýkoliv předmět nebo jakéhokoliv hmotného tvora, který je blíž než 50 sáhů a není zastíněn nějakým jiným předmětem nebo tvorem. Bude také schopen zhruba určit jeho vzdálenost a velikost. Kroll nepozná, o jakého tvora jde, ale pozná například, kolik má nohou apod. S předměty v jeskyni a jejím vybavením to je podobné. Krollův ultrasluch je v podstatě stále ještě sluchem, a proto závisí na hluku, který krolla obklopuje. Kroll nemůže používat ultrasluch v prostředí, které je hlučnější než obyčejný lidský hovor. Kroll svůj ultrasluch nepoužívá automaticky. Chce-li tuto svou zvláštní schopnost použít, musí o tom říct Pánovi jeskyně. Prozkoumávání ultrasluchem je stejně rychlé jako pohled. Prostor, který by kroll očima přehlédl během jednoho kola, je schopen za stejnou dobu prozkoumat i ultrasluchem. Kroll je schopen díky svému ultrasluchu vnímat i netopýry (a delfíny a jiné tvory, vybavené sonarem), není ovšem schopen se s nimi nijak dorozumět ani s nimi komunikovat. Tyto cizí signály krollův ultrasluch neruší, není-li jich příliš mnoho. Například uprostřed hejna netopýrů kroll svoji zvláštní schopnost může použít jen stěží.", 11, 3, 1, 16, 200, 100 }
                });

            migrationBuilder.InsertData(
                table: "Worlds",
                columns: new[] { "Id", "AmountOfMagicInTheWorld", "WorldDescription", "WorldName" },
                values: new object[,]
                {
                    { 1, 100, "", "Fantasy svět" },
                    { 2, 25, "", "Postapo" },
                    { 3, 0, "", "Reálný svět" }
                });

            migrationBuilder.InsertData(
                table: "Naratives",
                columns: new[] { "Id", "Era", "NarrativeDescription", "NarrativeName", "WorldId", "Year" },
                values: new object[,]
                {
                    { 1, "Císaře C-Chou", "Příběh ve vzdálené číně", "Čína", 1, 679 },
                    { 2, "III", "Boje v Persii", "Řecko", 1, 679 },
                    { 3, "XXI", "podle Pc hry", "Warhammer", 2, 3754 }
                });

            migrationBuilder.InsertData(
                table: "SpecificSkill",
                columns: new[] { "Id", "InternalName", "Level", "LevelGroup", "MaxHealingPoints", "ProfessionClass", "ProfessionSkillId", "SkillSumPrice", "Skill_type", "SpecificDescription", "SpeedOfHealing" },
                values: new object[,]
                {
                    { 1, "Healing", 2, 3, 2, 1, 1, 20, "healing", "Postava si může vyléčit 2 za 2 směn/y životů", 2 },
                    { 2, "Healing", 3, 3, 4, 1, 1, 20, "healing", "Postava si může vyléčit 4 za 3 směn/y životů", 3 },
                    { 3, "Healing", 4, 3, 6, 1, 1, 20, "healing", "Postava si může vyléčit 6 za 3 směn/y životů", 3 },
                    { 4, "Healing", 5, 3, 8, 1, 1, 20, "healing", "Postava si může vyléčit 8 za 3 směn/y životů", 3 },
                    { 5, "Healing", 6, 3, 10, 1, 1, 20, "healing", "Postava si může vyléčit 10 za 3 směn/y životů", 3 },
                    { 6, "Healing", 7, 3, 12, 1, 1, 20, "healing", "Postava si může vyléčit 12 za 3 směn/y životů", 3 },
                    { 7, "Healing", 8, 3, 14, 1, 1, 20, "healing", "Postava si může vyléčit 14 za 3 směn/y životů", 3 },
                    { 8, "Healing", 9, 3, 16, 1, 1, 20, "healing", "Postava si může vyléčit 16 za 3 směn/y životů", 3 },
                    { 9, "Healing", 15, 3, 16, 1, 1, 20, "healing", "Postava si může vyléčit 16 za 4 směn/y životů", 4 },
                    { 10, "Healing", 16, 3, 16, 1, 1, 20, "healing", "Postava si může vyléčit 16 za 4 směn/y životů", 4 },
                    { 11, "Healing", 25, 3, 16, 1, 1, 20, "healing", "Postava si může vyléčit 16 za 5 směn/y životů", 5 },
                    { 12, "Healing", 35, 3, 16, 1, 1, 20, "healing", "Postava si může vyléčit 16 za 6 směn/y životů", 6 },
                    { 13, "Healing", 2, 3, 1, 18, 16, 20, "healing", "Postava si může vyléčit 1 za 1 směn/y životů", 1 },
                    { 14, "Healing", 3, 3, 2, 18, 16, 20, "healing", "Postava si může vyléčit 2 za 2 směn/y životů", 2 },
                    { 15, "Healing", 4, 3, 3, 18, 16, 20, "healing", "Postava si může vyléčit 3 za 3 směn/y životů", 3 },
                    { 16, "Healing", 5, 3, 4, 18, 16, 20, "healing", "Postava si může vyléčit 4 za 3 směn/y životů", 3 },
                    { 17, "Healing", 6, 1, 5, 18, 16, 20, "healing", "Postava si může vyléčit 5 za 3 směn/y životů", 3 },
                    { 18, "Healing", 7, 3, 6, 18, 16, 20, "healing", "Postava si může vyléčit 6 za 3 směn/y životů", 3 },
                    { 19, "Healing", 8, 3, 7, 18, 16, 20, "healing", "Postava si může vyléčit 7 za 3 směn/y životů", 3 },
                    { 20, "Healing", 6, 3, 8, 18, 16, 20, "healing", "Postava si může vyléčit 8 za 3 směn/y životů", 3 }
                });

            migrationBuilder.InsertData(
                table: "SpecificSkill",
                columns: new[] { "Id", "CategoryWeapon", "Initiative", "InitiativeText", "InternalName", "Level", "LevelGroup", "ProfessionClass", "ProfessionSkillId", "SkillSumPrice", "Skill_type", "SpecificDescription" },
                values: new object[,]
                {
                    { 21, 3, 3, "3/2", "MultipleAttack", 5, 0, 1, 7, 20, "multiple_attack", "Postava může zaútočit 2x v prvním kole a v dalším kole 1x" },
                    { 22, 1, 6, "2/1", "MultipleAttack", 10, 1, 4, 7, 20, "multiple_attack", "Postava může zaútočit 2x v každém kole" },
                    { 23, 3, 6, "2/1", "MultipleAttack", 15, 1, 4, 7, 20, "multiple_attack", "Postava může zaútočit 2x v každém kole" },
                    { 24, 1, 9, "5/2", "MultipleAttack", 16, 2, 4, 7, 20, "multiple_attack", "Postava může zaútočit 5x v prvním kole a v dalším kole 2x" },
                    { 25, 1, 12, "3/1", "MultipleAttack", 27, 2, 4, 7, 20, "multiple_attack", "Postava může zaútočit 3x v každém kole" },
                    { 26, 3, 9, "5/2", "MultipleAttack", 28, 2, 4, 7, 20, "multiple_attack", "Postava může zaútočit 5x v prvním kole a v dalším kole 2x" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BindingProfessionsSkills_ProfessionSkillId",
                table: "BindingProfessionsSkills",
                column: "ProfessionSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Naratives_WorldId",
                table: "Naratives",
                column: "WorldId");

            migrationBuilder.CreateIndex(
                name: "IX_NarrativeProfession_ProfessionsId",
                table: "NarrativeProfession",
                column: "ProfessionsId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceWorld_WorldsId",
                table: "RaceWorld",
                column: "WorldsId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificSkill_ProfessionSkillId",
                table: "SpecificSkill",
                column: "ProfessionSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BindingProfessionsSkills");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "NarrativeProfession");

            migrationBuilder.DropTable(
                name: "RaceWorld");

            migrationBuilder.DropTable(
                name: "SpecificSkill");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Naratives");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "ProfessionSkill");

            migrationBuilder.DropTable(
                name: "Worlds");
        }
    }
}
