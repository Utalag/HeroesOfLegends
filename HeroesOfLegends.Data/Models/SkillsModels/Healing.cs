using HeroesOfLegends.Data.Builders;
using HeroesOfLegends.Data.Interfaces.ISkills;
using System.ComponentModel;

namespace HeroesOfLegends.Data.Models.SkillsModels
{
    public class Healing : BaseSpecificSkill
    {

        private int maxHealingPoints;
        private int speedOfHealing;
        
        public int MaxHealingPoints { 
            get => maxHealingPoints;
            set 
            { 
                maxHealingPoints = value;
                SpecificDescription = String.Format("Postava si může vyléčit {1} Hp za 1 směnu, maximálně {0} Hp za den.",value,SpeedOfHealing);
            } 
        }
        public int SpeedOfHealing { 
            get => speedOfHealing;
            set
            {
                speedOfHealing = value;
                SpecificDescription = String.Format("Postava si může vyléčit {1} Hp za 1 směnu, maximálně {0} Hp za den.",MaxHealingPoints,value);
            }
        }

        public override string SpecificDescription { get => String.Format("Postava si může vyléčit {1} Hp za 1 směnu, maximálně {0} Hp za den.",MaxHealingPoints,SpeedOfHealing); }
       

        public override BaseSpecificSkill[] Initial(int firstId)
        {
            int id = firstId;
            var skill = new BaseSpecificSkill[]
            {
                // warrior 2
                new Healing
                {
                    Id=id++,
                    Level = 2,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 2,
                    SpeedOfHealing = 2,
                },
                // warrior 3
                new Healing
                {
                    Id=id++,
                    Level = 3,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 4,
                    SpeedOfHealing = 3,
                },
                // warrior 4
                new Healing
                {
                    Id=id++,
                    Level = 4,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 6,
                    SpeedOfHealing = 3,
                },
                // warrior 5
                new Healing
                {
                    Id=id++,
                    Level = 5,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 8,
                    SpeedOfHealing = 3,
                },
                // warrior 6
                new Healing
                {
                    Id=id++,
                    Level = 6,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 10,
                    SpeedOfHealing = 3,
                },
               // warrior 7
                new Healing
                {
                    Id=id++,
                    Level = 7,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 12,
                    SpeedOfHealing = 3,
                },
                // warrior 8
                new Healing
            {
                Id=id++,
                Level = 8,
                ProfessionSkillId = 1,
                LevelGroup = LevelGroupEnum.all,
                ProfessionClass = ProfessionClassEnum.N_warrior,
                InternalName = "Healing",
                SkillSumPrice = 20,
                MaxHealingPoints = 14,
                SpeedOfHealing = 3,
            },
                // warrior 9-14
                new Healing
                {
                    Id=id++,
                    Level = 9,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 16,
                    SpeedOfHealing = 3,
                },
                // warrior 15
                new Healing
                {
                    Id=id++,
                    Level = 15,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 16,
                    SpeedOfHealing = 4,
                },
                // warrior 16-24
                new Healing
                {
                    Id=id++,
                    Level = 16,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 16,
                    SpeedOfHealing = 4,
                },
                // warrior 25-34
                new Healing
                {
                    Id=id++,
                    Level = 25,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 16,
                    SpeedOfHealing = 5,
                },
                // warrior 35-36
                new Healing
                {
                    Id=id++,
                    Level = 35,
                    ProfessionSkillId = 1,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 16,
                    SpeedOfHealing = 6,
                },

                // archer 2
                new Healing
                {
                    Id=id++,
                    Level = 2,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 1,
                    SpeedOfHealing = 1,

                },
                // archer 3
                new Healing
                {
                    Id=id++,
                    Level = 3,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 2,
                    SpeedOfHealing = 2,
                },
                // archer 4
                new Healing
                {
                    Id=id++,
                    Level = 4,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 3,
                    SpeedOfHealing = 3,
                },
                // archer 5
                new Healing
                {
                    Id=id++,
                    Level = 5,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 4,
                    SpeedOfHealing = 3,
                },
                // archer 6
                new Healing
                {
                    Id=id++,
                    Level = 6,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.advenced,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 5,
                    SpeedOfHealing = 3,
                },
                // archer 7
                new Healing
                {
                    Id=id++,
                    Level = 7,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 6,
                    SpeedOfHealing = 3,
                },
                // archer 8
                new Healing
                {
                    Id=id++,
                    Level = 8,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 7,
                    SpeedOfHealing = 3,
                },
                // archer 9
                new Healing
                {
                    Id=id++,
                    Level = 6,
                    ProfessionSkillId = 16,
                    LevelGroup = LevelGroupEnum.all,
                    ProfessionClass = ProfessionClassEnum.archer,
                    InternalName = "Healing",
                    SkillSumPrice = 20,
                    MaxHealingPoints = 8,
                    SpeedOfHealing = 3,
                },
            };
            return skill;
        }

        public override string? ToString()
        {
            return String.Format("Postava si může vyléčit {0} Hp za 1 směnu, maximálně {1} Hp",SpeedOfHealing,MaxHealingPoints);
        }
    }

}
