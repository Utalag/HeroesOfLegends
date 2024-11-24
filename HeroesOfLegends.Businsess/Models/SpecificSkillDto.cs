using HeroesOfLegends.Data.Interfaces.ISkills;
using HeroesOfLegends.Data.Interfaces.IWeapons;
using HeroesOfLegends.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Businsess.Models
{
    public class SpecificSkillDto: IHealing, IWeaponEstimate, IBaseSkillData, IEnemiEstimate,IWeaponsType
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string InternalName { get; set; } = string.Empty;
        public string SpecificDescription { get; set; } = string.Empty;
        public int SkillSumPrice { get; set; } // (Cz: Cena profesních bodů jako suma *vápočet*)

        public ProfessionClassEnum ProfessionClass { get; set; }
        public LevelGroupEnum LevelGroup { get; set; }


        public int ProfessionSkillId { get; set; } // ForeignKey k ProfessionSkill
        public virtual ProfessionSkill? ProfessionSkill { get; set; }  // Navigační vlastnost k ProfessionSkill



        public int MaxHealingPoints { get; set; }
        public int SpeedOfHealing { get; set; }
        public CategoryWeaponEnum CategoryWeapon { get; set; }
    }
}
