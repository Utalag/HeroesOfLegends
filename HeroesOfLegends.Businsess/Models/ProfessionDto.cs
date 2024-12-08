using System.ComponentModel.DataAnnotations;

namespace HeroesOfLegends.Businsess.Models
{
    public class ProfessionDto
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "Název povolání je povinný")]
        [Length(4, 100)]
        [Display(Name = "Název povolání")]
        public string Name { get; set; } = string.Empty;

        [Display(Description = "Popis")]// 
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Úroveň")]
        [Range(1, 36)]
        public int Level { get; set; }

        [Display(Name = "Životy Min")]
        [Range(1,1000)]
        public int HpRangeMin { get; set; }

        [Display(Name = "Životy Max")]
        [Range(2,1000)]// [Display (Hp = "Životy")]
        public int HpRangeMax { get; set; }

        [Display(Name = "Kouzelnická Mana")]
        [Range(0, 1000000)]
        public int WizardMana { get; set; }

        [Range(0,1000000)]
        [Display(Name = "Hraničářská Mana")]
        public int RengerMana { get; set; }

        [Range(0,1000000)]
        [Display(Name = "Kouzelnická Mana")]
        public int AlchemiMana { get; set; }

        [Range(0,1000000)]
        [Display(Name = "Speciální Mana")]
        public int SpecialdMana { get; set; }

        [Range(18,23)]
        [Display(Name = "Profesní body")]
        public int ProfiPoints { get; set; } 

        public bool HasWizardMana { get; set; }
        public bool HasRengerMana { get; set; }
        public bool HasAlchemiMana { get; set; }
        public bool HasSpecialdMana { get; set; }


        public List<int>? BeginnerSkillIds { get; set; } = new List<int>();
        public List<int>? AdvancedSkillIds { get; set; } = new List<int>();
        public List<int>? ExpertSkillIds { get; set; } = new List<int>();

        



    }
}


