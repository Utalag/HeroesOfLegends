using HeroesOfLegends.Data.Models.BindingTables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HeroesOfLegends.Data.Models
{


    public class Profession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;            // [Display (Name = "Název povolání")]
        public string Description { get; set; } = string.Empty;     // [Display (Description = "Popis")]
        public int Level { get; set; }                              // [Display (Level = "Úroveň")]
        public int HpRangeMin { get; set; }                         // [Display (Hp = "Životy")]
        public int HpRangeMax { get; set; }
        public int WizardMana { get; set; }
        public bool HasWizardMana { get; set; } = false;
        public int RengerMana { get; set; }
        public bool HasRengerMana { get; set; } = false;
        public int AlchemiMana { get; set; }
        public bool HasAlchemiMana { get; set; } = false;
        public int SpecialdMana { get; set; }
        public bool HasSpecialdMana { get; set; } = false;

        public int ProfiPoints { get; set; }





        //-----------------------------------------------------------  BINDING  ---------------

        public virtual ICollection<ProfessionSkill>? BeginnerSkills { get; set; } = new List<ProfessionSkill>();
        public virtual ICollection<ProfessionSkill>? AdvancedSkills { get; set; } = new List<ProfessionSkill>();
        public virtual ICollection<ProfessionSkill>? ExpertSkills { get; set; } = new List<ProfessionSkill>();


        public virtual IList<Narrative> Narratives { get; set; } = new List<Narrative>();
        public virtual IList<Character> Characters { get; set; } = new List<Character>();


        //---------------------------------INIT--------------------------------------------

        public Profession[] ProfessionInit()
        {
            return new Profession[]
            {
                new Profession
                {
                    Id = 1,
                    Name = "Válečník",
                    Description = "Zkušený bojovník, který se specializuje na zbraně a bojovou taktiku. Je fyzicky zdatný a často nosí těžké brnění. Válečníci vedou své spojence do bitvy a používají svou sílu a odvahu k ochraně ostatních. Jsou loajální a čestní, připravení postavit se jakékoli hrozbě.",
                    Level = 1,
                    HpRangeMin = 1,
                    HpRangeMax = 10,
                },
                new Profession
                {
                        Id = 2,
                    Name = "Kouzelník",
                    Description = "Mistr magie, ovládající sílu živlů a starodávných kouzel. Často se věnuje studiu mystických textů a hledá tajemství ukrytá ve stínech. Kouzelníci jsou schopni léčit, klamat nepřátele nebo vytvářet ničivá kouzla. Jsou intelektuálně založení a často se spoléhají na svou moudrost a znalosti.",
                    Level = 1,
                    HpRangeMin = 1,
                    HpRangeMax = 6,
                    WizardMana = 7,
                    HasWizardMana = true
                },
                new Profession
                {
                    Id = 3,
                    Name = "Alchymista",
                    Description = "Vědec a badatel, který míchá elixíry a hledá tajemství transmutace. Alchymisté jsou známí svou schopností vytvářet léčivé lektvary, výbušniny a různé magické substance. Jejich práce často hraničí s tajemnem a někteří se snaží najít kámen mudrců. Je to povolání plné experimentů a objevů.",
                    Level = 1,
                    HpRangeMin = 1,
                    HpRangeMax = 8,
                    AlchemiMana = 9,
                    HasAlchemiMana = true
                },
                new Profession
                {
                    Id = 4,
                    Name = "Lučištník",
                    Description = "Mistr lukostřelby a lovec, který se specializuje na střelbu z dálky. Lučištníci jsou rychlí a obratní, schopní zasáhnout nepřítele z velké vzdálenosti. Používají luky, kuše a střelné zbraně k ochraně svých spojenců a lovu zvěře. Jsou často samotáři a preferují život v divočině.",
                    Level = 1,
                    HpRangeMin = 1,
                    HpRangeMax = 8,
                },
                new Profession
                {
                    Id = 5,
                    Name = "Zloděj",
                    Description = "Mistr lstí a skrytých operací, který se specializuje na krádeže a infiltraci. Je rychlý, tichý a vysoce obratný, což mu umožňuje snadno unikat nepřátelům. Zloději využívají své dovednosti k získávání informací a cenností. Jsou inteligentní a vynalézaví, často pracující ve stínu.",
                    Level = 1,
                    HpRangeMin = 1,
                    HpRangeMax = 6,
                },
                new Profession
                {
                    Id = 6,
                    Name = "Hraničář",
                    Description = "Mistr přežití v divočině, který často slouží jako stopař a strážce. Má hluboké znalosti o přírodě a umí se pohybovat nepozorovaně. Hraničáři bývají vynikající lučištníci a lovci, kteří využívají svých dovedností k ochraně říše před nebezpečím. Spojují fyzickou zdatnost s bystrým instinktem.",
                    Level = 1,
                    HpRangeMin = 1,
                    HpRangeMax = 7,
                    RengerMana = 0,
                    HasRengerMana = true
                },
            };
        }
    }
}


