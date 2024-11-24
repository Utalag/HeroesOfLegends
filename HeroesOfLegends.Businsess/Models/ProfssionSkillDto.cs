using HeroesOfLegends.Data.Interfaces.ISkills;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;
namespace HeroesOfLegends.Businsess.Models
{
    public class ProfessionSkillDto 
    {
        public int Id { get; set; }
        public bool IsSelected { get; set; } = false; // (Cz: Vybráno)                                  //false
        public string SkillName { get; set; } = string.Empty;                                           //Healing
        public string NormalizeSkillName { get => SkillName.ToUpper(); }                                //HEALING
        public LevelGroupEnum KnowledgeGroup { get; set; } // example: novice, advanced, expert     //KnowledgeGroupEnum.novice
        public SkillClassEnum SkillClass { get; set; } // (Cz: Profesní třída)                          //SkillClassEnum.combatSkill
        public ProfessionClassEnum ProfessionClass { get; set; } // (Cz: Profesní třída)                //ProfessionClassEnum.warrior
        public int DependencySkillId { get; set; }// (Cz: Závislost na jiném skillu)                          // null (0)
        public int BaseProfessionPoint { get; set; } // (Cz: Základní profesní body)                    //2
        public string BaseDescription { get; set; } = string.Empty; // (Cz: Základní popis)             //Postava si dokáže sama vyléit zranění
        public string CreatetByUserName { get; set; } = string.Empty; // (Cz: vytvořil uživatel ???)    //Admin

        public virtual IList<BaseSpecificSkill> BaseSpecificSkills { get; set; } = new List<BaseSpecificSkill>(); // (Cz: Základní specifické dovednosti) //null
    }
}
