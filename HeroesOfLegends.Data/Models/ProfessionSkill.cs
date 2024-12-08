using HeroesOfLegends.Data.Models.BindingTables;
using HeroesOfLegends.Data.Models.SkillsModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HeroesOfLegends.Data.Models
{
    public class ProfessionSkill
    {
        /*
         * Porfesion skill obsahuje základní informace o dovednosti zařazení atd.
         * Obsahuje seznam specifických dovedností 
         */

        /*Exaplne:
         * SkillName: Healing
         * NormalizeSkillName: HEALING
         * KnowledgeGroup: novice
         * SkillClass: combatSkill
         * ProfessionClass: warrior
         * DependencySkillId: null
         * BaseProfessionPoint: 2
         * BaseDescription: Postava si dokáže sama vyléit zranění
         * CreatetByUserName: Admin
         */


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SkillName { get; set; } = string.Empty;
        public string NormalizeSkillName { get => SkillName.ToUpper(); }
        public LevelGroupEnum KnowledgeGroup { get; set; } // example: novice, advanced, expert
        public SkillClassEnum SkillClass { get; set; } // (Cz: Profesní třída)
        public ProfessionClassEnum ProfessionClass { get; set; } // (Cz: Profesní třída)
        public int DependencySkillId { get; set; }// (Cz: Závislost na jiném skillu)
        public string DependencySkillName { get; set; } = string.Empty;// (Cz: Závislost na jiném skillu)
        public int BaseProfessionPoint { get; set; } // (Cz: Základní profesní body)
        public string BaseDescription { get; set; } = string.Empty; // (Cz: Základní popis)
        public string CreatetByUserName { get; set; } = string.Empty;
        public virtual IList<BaseSpecificSkill>? BaseSpecificSkills { get; set; } = new List<BaseSpecificSkill>(); // (Cz: Základní specifické dovednosti)



        // ---------------------------- INIT--------------------------------
        public List<ProfessionSkill> ProfessionSkillInit()
        {
            var skills = new List<ProfessionSkill>
            {
            // warrior
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Léčba vlastních zranění II",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad soupeře",            BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad zbraně",             BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Poznání artefaktu",        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Přesnost",                 BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sehranost",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vícenásobné útoky",        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zastrašení",               BaseDescription = "", CreatetByUserName = "Admin",  },
                // hunter                                                                                                                                                        
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.huntingSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Boj se zvýřaty",           BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.huntingSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Stopování",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Hraničářská mana",         BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Kouzla",                   BaseDescription = "", CreatetByUserName = "Admin", DependencySkillName="Hraničářská mana"},
            new ProfessionSkill { BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Mymosmysloví schopnosti",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zmámení",                  BaseDescription = "", CreatetByUserName = "Admin", DependencySkillName="Hraničářská mana"},
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.huntingSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Pes",                      BaseDescription = "", CreatetByUserName = "Admin",  },
                // alchemist
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odolnost proti jedům",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Lučba a magenergie",    BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Lektvary",              BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Svitky",                BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Ostatní",               BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zbraně",                BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Prsteny",               BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Jedy",                  BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Výbušniny",             BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Lučba a magenergie"},
                // wizard
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Kouzelnický přítel",         BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Kouzelnická magenergie",     BaseDescription = "", CreatetByUserName = "Admin",},
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Časoprostorová magie",       BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Energetická útočná magie",   BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Energetická obranná magie",  BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Materiální magie",           BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vitální magie",              BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Psychická magie",            BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Poznávací magie",            BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Iluzivní magie",             BaseDescription = "", CreatetByUserName = "Admin",DependencySkillName="Kouzelnická magenergie"},
                // thief
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Převleky",                    BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zisk důvěry",                 BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Objevení mechanismu",         BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Objevení objektu",            BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Šplh po zdech",               BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Skok z výšky",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Tichý pohyb",                 BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Schování se ve stínu",        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vybírání kapes",              BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Otevření objetu",             BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zneškodnění mechanismu",      BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.combatSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Probodnutí ze zálohy",       BaseDescription = "", CreatetByUserName = "Admin",  },
                // archer
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Léčba vlastních zranění I",   BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vícenásobné útoky ve střelbě",BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zrak",                        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad střelných zbraní",      BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad soupeře",               BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=5, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.otherSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Výroba šípů",                  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Krok a střelba",              BaseDescription = "", CreatetByUserName = "Admin",  },
                // Health         
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k6",                       BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k6+1",                     BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k6+2",                     BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k10",                      BaseDescription = "", CreatetByUserName = "Admin",  },
                // Primary Range  
            new ProfessionSkill { BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 23-24",                  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 25",                     BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 26",                     BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 27-28",                  BaseDescription = "", CreatetByUserName = "Admin",  }

            };
            return skills;
        }

        public ProfessionSkill[] Initial(int firstId)
        {
            int id = firstId;
            var skill = new ProfessionSkill[]
            {
                // warrior
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Léčba vlastních zranění II",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad soupeře",            BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad zbraně",             BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Poznání artefaktu",        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Přesnost",                 BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sehranost",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vícenásobné útoky",        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_warrior,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zastrašení",               BaseDescription = "", CreatetByUserName = "Admin",  },
                // hunter                                                                                                                                                   
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.huntingSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Boj se zvýřaty",           BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.huntingSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Stopování",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Hraničářská mana",         BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Kouzla",                   BaseDescription = "", CreatetByUserName = "Admin", DependencySkillId=12},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Mymosmysloví schopnosti",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.magicSkill  ,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zmámení",                  BaseDescription = "", CreatetByUserName = "Admin", DependencySkillId=12},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_hunter, SkillClass=SkillClassEnum.huntingSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Pes",                      BaseDescription = "", CreatetByUserName = "Admin",  },
                // alchemist         
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odolnost proti jedům",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Lučba a magenergie",    BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Lektvary",              BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Svitky",                BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Ostatní",               BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zbraně",                BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Prsteny",               BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Jedy",                  BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_alchemist, SkillClass=SkillClassEnum.alchemySkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Výbušniny",             BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=17},
                // wizard             
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Kouzelnický přítel",         BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Kouzelnická magenergie",     BaseDescription = "", CreatetByUserName = "Admin",},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Časoprostorová magie",       BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Energetická útočná magie",   BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Energetická obranná magie",  BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Materiální magie",           BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vitální magie",              BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Psychická magie",            BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Poznávací magie",            BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_wizard, SkillClass=SkillClassEnum.magicSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Iluzivní magie",             BaseDescription = "", CreatetByUserName = "Admin",DependencySkillId=26},
                // thief             
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Převleky",                    BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zisk důvěry",                 BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Objevení mechanismu",         BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Objevení objektu",            BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Šplh po zdech",               BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Skok z výšky",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Tichý pohyb",                 BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Schování se ve stínu",        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vybírání kapes",              BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Otevření objetu",             BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.thiefSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zneškodnění mechanismu",      BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.N_thief, SkillClass=SkillClassEnum.combatSkill,KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Probodnutí ze zálohy",       BaseDescription = "", CreatetByUserName = "Admin",  },
                // archer            
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Léčba vlastních zranění I",  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Vícenásobné útoky ve střelbě", BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Zrak",                         BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad střelných zbraní",       BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Odhad soupeře",                BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=5, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.otherSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Výroba šípů",                   BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.archer,SkillClass=SkillClassEnum.combatSkill, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Krok a střelba",               BaseDescription = "", CreatetByUserName = "Admin",  },
                // Health          
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k6",                        BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k6+1",                      BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k6+2",                      BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Životy 1k10",                       BaseDescription = "", CreatetByUserName = "Admin",  },
            // Primary Range          
            new ProfessionSkill { Id =id++,BaseProfessionPoint=1, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 23-24",                  BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=2, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 25",                     BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=3, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 26",                     BaseDescription = "", CreatetByUserName = "Admin",  },
            new ProfessionSkill { Id =id++,BaseProfessionPoint=4, ProfessionClass=ProfessionClassEnum.health,SkillClass=SkillClassEnum.health, KnowledgeGroup=LevelGroupEnum.novice, SkillName = "Sum range 27-28",                  BaseDescription = "", CreatetByUserName = "Admin",  }






            };
            return skill;
        }
    }
}
