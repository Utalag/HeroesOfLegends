
using System.ComponentModel.DataAnnotations;
namespace HeroesOfLegends.Data.Models
{

    public enum SkillClassEnum
    {

        combatSkill = 0,

        magicSkill = 1,

        huntingSkill = 2,

        alchemySkill = 3,

    }

    public class ProfessionSkill
    {

        [Key]
        public int SkillId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }

        public SkillClassEnum SkillClass { get; set; }
        public string Description { get; set; } = string.Empty;

        public string CreateByUserName { get; set; } = string.Empty; // (Cz: vytvořil uživatel ???)







        public ProfessionSkill[] Initial()
        {
            var skill = new ProfessionSkill[]
            {
                new ProfessionSkill { SkillId = 1, Name = "Swordsmanship", Level = 5, Description = "Mastery in sword fighting.", CreateByUserName = "Admin",SkillClass=SkillClassEnum.combatSkill },
                new ProfessionSkill { SkillId = 2, Name = "Archery", Level = 4, Description = "Skilled in using bows and arrows.", CreateByUserName = "Admin",SkillClass=SkillClassEnum.huntingSkill },
                new ProfessionSkill { SkillId = 3, Name = "Alchemy", Level = 3, Description = "Ability to create potions and elixirs.", CreateByUserName = "Admin",SkillClass=SkillClassEnum.alchemySkill },
                new ProfessionSkill { SkillId = 4, Name = "Fire Magic", Level = 4, Description = "Control over fire spells.", CreateByUserName = "Admin",SkillClass=SkillClassEnum.magicSkill },
                new ProfessionSkill { SkillId = 5, Name = "Stealth", Level = 3, Description = "Expertise in moving unseen.", CreateByUserName = "Admin", SkillClass=SkillClassEnum.combatSkill},
                new ProfessionSkill { SkillId = 6, Name = "Healing", Level = 2, Description = "Ability to heal wounds and injuries.", CreateByUserName = "Admin",SkillClass=SkillClassEnum.alchemySkill}
            };
            return skill;
        }
    }
}
