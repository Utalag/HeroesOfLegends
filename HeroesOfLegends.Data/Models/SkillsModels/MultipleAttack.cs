using HeroesOfLegends.Data.Interfaces.IWeapons;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Data.Models.SkillsModels
{
    public class MultipleAttack : BaseSpecificSkill, IWeaponsType
    {
        public int Initiative { get; set; } // (Cz: Iniciativa)                         example: 3,6,9,12,15,18,21,24,27
        public string InitiativeText { get; set; } = string.Empty; // (Cz: Iniciativa)  example: 3/2,2/1,5/2,3/1,7/2,4/1,9/2,5/1,11/2   
        public CategoryWeaponEnum CategoryWeapon { get; set; } // (Cz: Kategorie zbraně)  example: melee,range,magic

        public override BaseSpecificSkill[] Initial(int firstId)
        {
            int id = firstId;
            var skill = new BaseSpecificSkill[]
            {
                // warrior 5
                new MultipleAttack
                {
                    Id = id++,
                    Level = 5,
                    ProfessionSkillId = 7,
                    InternalName = "MultipleAttack",
                    ProfessionClass = ProfessionClassEnum.N_warrior,
                    LevelGroup = LevelGroupEnum.novice,
                    CategoryWeapon = CategoryWeaponEnum.Melee,
                    SkillSumPrice = 20,
                    Initiative = 3,
                    InitiativeText = "3/2",
                    SpecificDescription = "Postava může zaútočit 2x v prvním kole a v dalším kole 1x"
                },
                // champion 10
                new MultipleAttack
                {
                    Id = id++,
                    Level = 10,
                    ProfessionSkillId = 7,
                    InternalName = "MultipleAttack",
                    ProfessionClass = ProfessionClassEnum.champion,
                    LevelGroup = LevelGroupEnum.advenced,
                    CategoryWeapon = CategoryWeaponEnum.TwoHanded,
                    SkillSumPrice = 20,
                    Initiative = 6,
                    InitiativeText = "2/1",
                    SpecificDescription = "Postava může zaútočit 2x v každém kole"
                },
                // champion 15
                new MultipleAttack
                {
                    Id = id++,
                    Level = 15,
                    ProfessionSkillId = 7,
                    InternalName = "MultipleAttack",
                    ProfessionClass = ProfessionClassEnum.champion,
                    LevelGroup = LevelGroupEnum.advenced,
                    CategoryWeapon = CategoryWeaponEnum.Melee,
                    SkillSumPrice = 20,
                    Initiative = 6,
                    InitiativeText = "2/1",
                    SpecificDescription = "Postava může zaútočit 2x v každém kole"
                },
                // champion 16
                new MultipleAttack
                {
                    Id = id++,
                    Level = 16,
                    ProfessionSkillId = 7,
                    InternalName = "MultipleAttack",
                    ProfessionClass = ProfessionClassEnum.champion,
                    LevelGroup = LevelGroupEnum.master,
                    CategoryWeapon = CategoryWeaponEnum.TwoHanded,
                    SkillSumPrice = 20,
                    Initiative = 9,
                    InitiativeText = "5/2",
                    SpecificDescription = "Postava může zaútočit 5x v prvním kole a v dalším kole 2x"
                },
                // champion 27
                new MultipleAttack
                {
                    Id = id++,
                    Level = 27,
                    ProfessionSkillId = 7,
                    InternalName = "MultipleAttack",
                    ProfessionClass = ProfessionClassEnum.champion,
                    LevelGroup = LevelGroupEnum.master,
                    CategoryWeapon = CategoryWeaponEnum.TwoHanded,
                    SkillSumPrice = 20,
                    Initiative = 12,
                    InitiativeText = "3/1",
                    SpecificDescription = "Postava může zaútočit 3x v každém kole"
                },
                // champion 28
                new MultipleAttack
                {
                    Id = id++,
                    Level = 28,
                    ProfessionSkillId = 7,
                    InternalName = "MultipleAttack",
                    ProfessionClass = ProfessionClassEnum.champion,
                    LevelGroup = LevelGroupEnum.master,
                    CategoryWeapon = CategoryWeaponEnum.Melee,
                    SkillSumPrice = 20,
                    Initiative = 9,
                    InitiativeText = "5/2",
                    SpecificDescription = "Postava může zaútočit 5x v prvním kole a v dalším kole 2x"
                }
            };

            return skill;
        }

       
    }
}
