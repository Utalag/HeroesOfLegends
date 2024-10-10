using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HeroesOfLegends.Businsess.Models
{
    public class CharacterDto
    {

        //-------------- DATABASE DATA----------------

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;        // example : "Bilbo"
        public string Description { get; set; } = string.Empty; // example : "Lorem Ypsum"
        public int RaceId { get; set; }                         // example : 1


        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Strengt { get; set; }          //example :  [9,-1]
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Agility { get; set; }          //example :  [14,1]
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Constitution { get; set; }     //example :  [16,2]
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Intelligence { get; set; }     //example :  [13,1]
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Charisma { get; set; }         //example :  [14,1]
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Mobility { get; set; }         //example :  [9,-1]
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public int[] Visage { get; set; }           //example :  [13,1]
        public int Profipoints { get; set; }        //example :  23

        public AtributEnum PrimaryAtribut_1 { get; set; }  // primary atribute 1 (CZ: primární atribut 1)               example : AtributEnum.strength,
        public AtributEnum PrimaryAtribut_2 { get; set; }   // primary atribute 2 (CZ: primární atribut 2)              example : AtributEnum.agility

        public int PrimarValueIndex_1 { get; set; } // index of primary atribute 1 (CZ: index primárního atributu 1)    example :0 (primary atribut is 11) 
        public int PrimarValueIndex_2 { get; set; } // index of primary atribute 2 (CZ: index primárního atributu 2)    example :1 (primary atribut is 14)


        // final range atributes (CZ: finální rozsah atributů)
        public int[] StrengthFinalRange { get; set; }       //example :  [6,11]
        public int[] AgilityFinalRange { get; set; }        //example :  [11,16]
        public int[] ConstitutionFinalRange { get; set; }   //example :  [13,18]
        public int[] IntelligenceFinalRange { get; set; }   //example :  [10,15]
        public int[] CharismaFinalRange { get; set; }       //example :  [8,18]











        // ----------------------- NOT SAVE TO DATABASE -------------------
        [NotMapped]
        public Dictionary<int,int> AtributBonus { get; } = new Dictionary<int,int>()
        {
            [1] = -5,
            [2] = -4,
            [3] = -4,
            [4] = -3,
            [5] = -3,
            [6] = -2,
            [7] = -2,
            [8] = -1,
            [9] = -1,
            [10] = 0,
            [11] = 0,
            [12] = 0,
            [13] = 1,
            [14] = 1,
            [15] = 2,
            [16] = 2,
            [17] = 3,
            [18] = 3,
            [19] = 4,
            [20] = 4,
            [21] = 5,
            [22] = 5,
            [23] = 7,
            [24] = 7,
            [25] = 8,
            [26] = 8,
            [27] = 9,
            [28] = 9,
            [29] = 10,
            [30] = 10,
        };

        // atribute labels (CZ: názvy atributů)
        [NotMapped] public string strengthLabel = "Síla";
        [NotMapped] public string agilityLabel = "Obratnost";
        [NotMapped] public string constitutionLabel = "Odolnost";
        [NotMapped] public string intelligenceLabel = "Inteligence";
        [NotMapped] public string charismaLabel = "Charisma";

        // defined primary atributes (CZ: definované primární atributy)
        [NotMapped] public int[] PrimaryStrength { get => [11,13]; }
        [NotMapped] public int[] PrimaryAgility { get => [13,14]; }
        [NotMapped] public int[] PrimaryConstitution { get => [12,13]; }
        [NotMapped] public int[] PrimaryIntelligence { get => [13,14]; }
        [NotMapped] public int[] PrimaryCharisma { get => [12,13]; } 

    }
}
