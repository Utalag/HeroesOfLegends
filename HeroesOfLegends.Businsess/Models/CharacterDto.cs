using System.ComponentModel.DataAnnotations;

namespace HeroesOfLegends.Businsess.Models

{
    public enum AtributEnum
    {
        [Display(Name = "Síla")]
        strength = 0,
        [Display(Name = "Obratnost")]
        agility = 1,
        [Display(Name = "Odolnost")]
        constitution = 2,
        [Display(Name = "Inteligence")]
        intelligence = 3,
        [Display(Name = "Charisma")]
        charisma = 4
    }

    public class CharacterDto
    {
        //--------------SAVE TO DATABASE----------------

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // character name (Cz: Jméno postavy)
        public string Description { get; set; } = string.Empty; // charatcer description (Cz: Popis postavy)
        public int RaceId { get; set; } // Race ID (Cz: Rasa)
        public int ProfessionId { get; set; }

        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Strengt { get; set; }        //15+2   // (Cz: Síla) 
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Agility { get; set; }        //10+0   // (Cz: Obratnost) 
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Constitution { get; set; }   //9-1    // (Cz: Odolnost)
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Intelligence { get; set; }   //17+3   // (Cz: Inteligence)
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Charisma { get; set; }       //19+4   // (Cz: Charisma)
        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Mobility { get; set; }       //7-2    // (Cz: Pohyblivost)


        public int Strength_DiceRollSum { get; set; }       // Sum dice roll (Cz: Součet hodů kostkou)
        public int Agility_DiceRollSum { get; set; }        // Sum dice roll (Cz: Součet hodů kostkou)
        public int Constitution_DiceRollSum { get; set; }   // Sum dice roll (Cz: Součet hodů kostkou)
        public int Intelligence_DiceRollSum { get; set; }   // Sum dice roll (Cz: Součet hodů kostkou)
        public int Charisma_DiceRollSum { get; set; }       // Sum dice roll (Cz: Součet hodů kostkou)

        public AtributEnum PrimaryAtribut_1  { get; set; }  // primary atribute 1 (CZ: primární atribut 1)
        public AtributEnum PrimaryAtribut_2 { get; set; }   // primary atribute 2 (CZ: primární atribut 2)

        //--------------NOT SAVE TO DATABASE----------------



        // primary atributes range (CZ: rozsah primárních atributů)
        public ValueTuple<int,int> StrengthRangePrimary {get;set;}
        public ValueTuple<int,int> AgilityRangePrimary {get;set;}
        public ValueTuple<int,int> ConstitutionRangePrimary {get;set;}
        public ValueTuple<int,int> IntelligenceRangePrimary {get;set;}
        public ValueTuple<int,int> CharismaRangePrimary {get;set;}

        // final range atributes (CZ: finální rozsah atributů)
        public ValueTuple<int,int> StrengthFinalRange{get;set;}
        public ValueTuple<int,int> AgilityFinalRange {get;set;}
        public ValueTuple<int,int> ConstitutionFinalRange {get;set;}
        public ValueTuple<int,int> IntelligenceFinalRange {get;set;}
        public ValueTuple<int,int> CharismaFinalRange {get;set;}

    }
}
