using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HeroesOfLegends.Businsess.Models
{
    public class RaceDto
    {
        [JsonPropertyName("Id")]
        public int RaceId { get; set; }

        [Display(Name = "Název rasy"), Required(ErrorMessage = "Jméno musí mít minimílně 2 znaky"),]
        public string RaceName { get; set; } = string.Empty;

        [Display(Name = "Popis rasy")]
        public string RaceDescription { get; set; } = string.Empty;

        [Display(Name = "Velikost")]
        [RegularExpression(@"^[A-D]",ErrorMessage = "Povolené znaky jsou A,B,C,D,E")]
        public string RaceSize { get; set; } = string.Empty;

        [Display(Name = "Pohyblivost")]
        public int Mobility { get; set; }

        [Display(Name = "Specíální dovednost")]
        public string? SpecialAbilities { get; set; }


        [Display(Name = "Síla")]
        public int Strength { get; set; }
        [Display(Name = "Síla Max")]
        public int Strength_Max { get; set; }
        [Display(Name = "Oprava")]
        public int Strength_Corection { get; set; }

        [Display(Name = "Obratnost")]
        public int Agility { get; set; }
        [Display(Name = "Obratnost Max")]
        public int Agility_Max { get; set; }
        [Display(Name = "Oprava")]
        public int Agility_Corection { get; set; }

        [Display(Name = "Odolnost")]
        public int Constitution { get; set; }
        [Display(Name = "Odolnost Max")]
        public int Constitution_Max { get; set; }
        [Display(Name = "Oprava")]
        public int Constitution_Corection { get; set; }

        [Display(Name = "Inteligence")]
        public int Intelligence { get; set; }
        [Display(Name = "Inteligence Max")]
        public int Intelligence_Max { get; set; }
        [Display(Name = "Oprava")]
        public int Intelligence_Correction { get; set; }

        [Display(Name = "Charisma")]
        public int Charisma { get; set; }
        [Display(Name = "Charisma Max")]
        public int Charisma_Max { get; set; }

        public int Charisma_Correction { get; set; }
        public int Strength_DiceRoll { get; set; }
        public int Dexterity_DiceRoll { get; set; }
        public int Constitution_DiceRoll { get; set; }
        public int Intelligence_DiceRoll { get; set; }
        public int Charisma_DiceRoll { get; set; }
    }
}
