using HeroesOfLegends.Data.Interfaces.ISkills;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Data.Models.SkillsModels
{
    public abstract class BaseSpecificSkill : IBaseSkillData
    {
        /*
Detailně popisuje konkrétní dovednost, která je součástí ProfessionSkill.
*/
        [NotMapped]
        public static int NextId { get; set; } = 1;
        
       
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Level { get; set; }
        public string InternalName { get; set; } = string.Empty;
        public virtual string SpecificDescription { get; set; } = string.Empty;
        public int SkillSumPrice { get; set; } // (Cz: Cena profesních bodů jako suma *vápočet*)

        public ProfessionClassEnum ProfessionClass { get; set; }
        public LevelGroupEnum LevelGroup { get; set; }

        //Navigation
        [ForeignKey("ProfessionSkill")]
        public int ProfessionSkillId { get; set; } // ForeignKey k ProfessionSkill

        private string professionSkillName = string.Empty;
        public string ProfessionSkillName 
        { 
            get=>professionSkillName;
            set 
            {
                professionSkillName = value;
                //TOTO vyhledat v Db název ProfessionSkill a nastavit Id do ProfessionSkillId
            } 
        } // Název ProfessionSkill

        public virtual ProfessionSkill? ProfessionSkill { get; set; }  // Navigační vlastnost k ProfessionSkill

        public virtual BaseSpecificSkill[] Initial(int firstId)
        {
            return null;
        }
        


    }
}



