

namespace HeroesOfLegends.Data.Models
{
    public class Character
    {
        public enum AtributEnum
        {

            strength = 0,
            agility = 1,
            constitution = 2,
            intelligence = 3,
            charisma = 4
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;        // character name (Cz: Jméno postavy)
        public string Description { get; set; } = string.Empty; // charatcer description (Cz: Popis postavy)
        public int RaceId { get; set; }                         // Race ID (Cz: Rasa)
        public virtual Race? Race { get; set; }
        public int ProfessionId { get; set; }                   // Profese (Cz: Povolání)
        public virtual Profession? Profession { get; set; }


        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Strengt { get; set; } = new int[2];
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Agility { get; set; } = new int[2];
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Constitution { get; set; } = new int[2];
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Intelligence { get; set; } = new int[2];
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Charisma { get; set; } = new int[2];
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Mobility { get; set; } = new int[2];
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Visage { get; set; } = new int[2];
        public int Profipoints { get; set; } // profipoints (Cz: profibody)

        public AtributEnum PrimaryAtribut_1 { get; set; }  // primary atribute 1 (CZ: primární atribut 1)
        public AtributEnum PrimaryAtribut_2 { get; set; }   // primary atribute 2 (CZ: primární atribut 2)

        public int PrimarValueIndex_1 { get; set; } // index of primary atribute 1 (CZ: index primárního atributu 1)
        public int PrimarValueIndex_2 { get; set; } // index of primary atribute 2 (CZ: index primárního atributu 2)


        // final range atributes (CZ: finální rozsah atributů)
        public int[] StrengthFinalRange { get; set; } = new int[2];
        public int[] AgilityFinalRange { get; set; } = new int[2];
        public int[] ConstitutionFinalRange { get; set; } = new int[2];
        public int[] IntelligenceFinalRange { get; set; } = new int[2];
        public int[] CharismaFinalRange { get; set; } = new int[2];

        public Character[] Initial()
        {
            var data = new Character[]
            {
                new Character()
                {
                    
                }
            };
            return data;
        }
    }
}
