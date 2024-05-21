using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HeroesOfLegends.Data.Migrations
{
    /// <inheritdoc />
    public partial class Start : Migration
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
                name: "Fights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionSkill = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ProfessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    GetHpDiceRoll = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HpAllDiceRolls = table.Column<bool>(type: "bit", nullable: false),
                    HpPointeded = table.Column<int>(type: "int", nullable: false),
                    GetProfessionPointedDiceRoll = table.Column<int>(type: "int", nullable: false),
                    AtributePointed = table.Column<int>(type: "int", nullable: false),
                    ProfessionPoint = table.Column<int>(type: "int", nullable: false),
                    ManaWizardBool = table.Column<bool>(type: "bit", nullable: false),
                    ManaAlchemistBool = table.Column<bool>(type: "bit", nullable: false),
                    ManaRengerBool = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ProfessionId);
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
                    WorldName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    St_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Ag_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Co_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    In_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    Cha_DiceRoll = table.Column<int>(type: "int", nullable: false),
                    St_Primar = table.Column<int>(type: "int", nullable: false),
                    Ag_Primar = table.Column<int>(type: "int", nullable: false),
                    Co_Primar = table.Column<int>(type: "int", nullable: false),
                    In_Primar = table.Column<int>(type: "int", nullable: false),
                    Cha_Primar = table.Column<int>(type: "int", nullable: false),
                    St_bool = table.Column<bool>(type: "bit", nullable: false),
                    Ag_bool = table.Column<bool>(type: "bit", nullable: false),
                    Int_bool = table.Column<bool>(type: "bit", nullable: false),
                    Cha_bool = table.Column<bool>(type: "bit", nullable: false),
                    Con_bool = table.Column<bool>(type: "bit", nullable: false)
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RaceWorld_Worlds_WorldsId",
                        column: x => x.WorldsId,
                        principalTable: "Worlds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NarrativeProfession",
                columns: table => new
                {
                    NarrativesId = table.Column<int>(type: "int", nullable: false),
                    ProfessionsProfessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarrativeProfession", x => new { x.NarrativesId, x.ProfessionsProfessionId });
                    table.ForeignKey(
                        name: "FK_NarrativeProfession_Naratives_NarrativesId",
                        column: x => x.NarrativesId,
                        principalTable: "Naratives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NarrativeProfession_Professions_ProfessionsProfessionId",
                        column: x => x.ProfessionsProfessionId,
                        principalTable: "Professions",
                        principalColumn: "ProfessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "ProfessionId", "AtributePointed", "Description", "GetHpDiceRoll", "GetProfessionPointedDiceRoll", "HpAllDiceRolls", "HpPointeded", "Level", "ManaAlchemistBool", "ManaRengerBool", "ManaWizardBool", "Name", "ProfessionPoint" },
                values: new object[,]
                {
                    { 1, 25, "Válečník je silný a houževnatý. Vládne mnoha druhy zbraní a umí se v jejich používání zdokonalovat. V boji má větší šanci, že nepřítele zasáhne. A vzhledem k tomu, že bitvy a souboje jsou v Dračím doupěti běžné, je pro každou družinu nezbytné, aby ve svém středu měla jednoho nebo více válečníků. Postavy jiných povolání sice také mohou bojovat, ale mohou být svázány rozličnými omezeními. Válečníci jsou jediní, kteří boj skutečně studují a mají v něm některé výhody, které žádné jiné povolání nemá.", "[10]", 1, true, 4, 3, false, false, false, "Válečník", 18 },
                    { 2, 24, "Hraničář je silný a moudrý. Zná přírodu a tvory, kteří ji obývají, a umí svých znalostí využívat. V boji má určitá omezení, ale stále může být platným bojovníkem po boku válečníka. Kromě toho je vhodný jako silná zadní stráž v družinách, které nemají dost válečníků (a takových družin bude většina).\r\nHraničáři zpravidla žijí v hlubokých hvozdech, kde sami, jen se svými psy, střeží stezky a pomáhají těm, kdo pomoc potřebují. Proto jsou takřka všude vítanými hosty. Dlouholetým stykem s přírodou a přírodní magií se u nich vyvíjejí i jisté nadpřirozené schopnosti, které jim pomáhají při jejich nebezpečném a osamoceném životě alespoň tak se to mezi lidmi povídá.\r\nHraničáři se dají přemluvit, aby se připojili k družině. Jsou vynikajícími lovci a stopaři a proto jsou neocenitelní při dobrodružstvích ve volné přírodě. Ale jejich mimořádné schopnosti jsou užitečné i jinde, například v podzemí. V boji i mimo něj je hraničář hodnotným členem každé družiny.\r\n", "[6]", 4, true, 1, 1, false, true, false, "Hraničář", 21 },
                    { 3, 27, "Alchymista je šikovný a leccos vydrží. Zabývá se výrobou lektvarů a různých kouzelných předmětů. V boji většinou nepomáhá přímo, ale prostřednictvím svého umění. Alchymisté se liší od kouzelníků svým přístupem k magii. Zatímco kouzelníci rozvíjejí svou inteligenci a z ní získávají magenergii, alchymisté ji destilují z různých předmětů a záleží jen na jejich obratnosti, zda a kolik magenergie se jim z nich podaří vytěžit.\r\nDíky tomu jsou alchymisté bližší \"obyčejným\" lidem než kouzelníci a nevzbuzují u nich strach. Přesto mají svým způsobem mnohem důvěrnější vztah k magenergii než jiná povolání nadaná schopností kouzlit.\r\nAlchymistovy kouzelné předměty mohou být užitečné v mnoha různých situacích. Jejich účinky se často liší od účinků kouzelníkových kouzel a žádná družina neprodělá, když bude mít alchymistu ve svém středu.\r\n", "[6]", 6, true, 2, 1, true, false, false, "Alchymista", 23 },
                    { 4, 24, "Kouzelník je chytrý a umí ovlivňovat druhé. Není příliš silný v boji, ale vynahrazuje si to svými zvláštními schopnostmi, zejména studiem kouzel. Kouzelníci byli vždy terčem nejrůznějších dohadů a nikdo vlastně neví, co všechno mohou dokázat. Lidé se k nim chovají uctivě, ale podezřívavě a se strachem. Kouzelníci sami dávají přednost samotě, ve které studují svá kouzla, a stýkají se jenom se svým učitelem.\r\nKouzla jsou přirozenou so částí světa. Jsou předměty, které jsou bezcenné pro někoho, kdo se v kouzlech nevyzná, a které se mohou stát strašnou zbraní v rukou mága.\r\nŘadu situaci je mnohem lehčí vyřešit pomoci kouzla než obvyklým způsobem. Ale pozor! Nejde to vždy a zvláště zpočátku jsou kouzla spíše vzácná.\r\nPro své mimořádné schopnosti je kouzelník vyhledávaným členem každé družiny. Je pravda, že většinu času alespoň zpočátku - zůstávají tyto schopnosti nevyužity, ale okamžik, kdy je použije, může znamenat rozhodující zvrat v celém dobrodružství.\r\n", "[6]", 2, true, 1, 1, false, false, true, "Kouzelník", 19 },
                    { 5, 25, "Zloděj je mrštný a umí se vloudit do přízně jiných lidí. V boji zpravidla nestojí v první řadě a není to ani jeho poslání, ale dokáže i tvrdě zasáhnout.\r\nZloději jsou odborníky na nebezpečné situace, které vyžadují vtip a obratnost místo hrubé síly. Zloději studují své řemeslo v obávaném zlodějském cechu a prostí lidé si vyprávějí bájné zkazky o jejich umění. O zlodějích, kteří sami pronikli do přísně střežených pevností nebo zakletých hrobek a ukradli královské poklady, o zlodějích, kteří unikli z okovů v podzemním žaláři, hlídaném těmi nejlepšími z královské gardy.\r\nZloději z pochopitelných důvodů jen neradi odhalují svou profesi. Dokážou být velice zábavní společníci, snadno si získají přízeň jiných lidí a zjisti tak množství zajímavých informaci. Ty pak využijí ke svému prospěchu, nebo k prospěchu družiny.\r\nDíky svým pozoruhodným schopnostem, které nemá žádné jiné povolání, je zloděj žádaným členem v každé družině. Postavám, se kterými půjde, ušetří mnoho nesnází.\r\n", "[6]", 3, true, 1, 1, false, false, false, "Zloděj", 20 }
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
                columns: new[] { "Id", "WorldName" },
                values: new object[,]
                {
                    { 1, "Fantasy svět" },
                    { 2, "Postapo" },
                    { 3, "Reálný svět" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Ag_DiceRoll", "Ag_Primar", "Ag_bool", "Agility", "Cha_DiceRoll", "Cha_Primar", "Cha_bool", "Charisma", "Co_DiceRoll", "Co_Primar", "Con_bool", "Constitution", "Description", "In_DiceRoll", "In_Primar", "Int_bool", "Intelligence", "Name", "ProfessionId", "RaceId", "St_DiceRoll", "St_Primar", "St_bool", "Strength" },
                values: new object[] { 1, 4, 2, true, 0, 4, 0, false, 0, 4, 2, false, 0, "Drobný hobit pocházející z Kraje za Hvozdem.", 4, 2, false, 0, "Bilbo Pytlík", 1, 1, 4, 2, true, 0 });

            migrationBuilder.InsertData(
                table: "Naratives",
                columns: new[] { "Id", "Era", "NarrativeDescription", "NarrativeName", "WorldId", "Year" },
                values: new object[,]
                {
                    { 1, "Císaře C-Chou", "Příběh ve vzdálené číně", "Čína", 1, 679 },
                    { 2, "III", "Boje v Persii", "Řecko", 1, 679 },
                    { 3, "XXI", "podle Pc hry", "Warhammer", 2, 3754 }
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
                name: "IX_Characters_ProfessionId",
                table: "Characters",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Naratives_WorldId",
                table: "Naratives",
                column: "WorldId");

            migrationBuilder.CreateIndex(
                name: "IX_NarrativeProfession_ProfessionsProfessionId",
                table: "NarrativeProfession",
                column: "ProfessionsProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceWorld_WorldsId",
                table: "RaceWorld",
                column: "WorldsId");
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
                name: "Fights");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "NarrativeProfession");

            migrationBuilder.DropTable(
                name: "RaceWorld");

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
                name: "Worlds");
        }
    }
}
