using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        private ValueTuple<int,int> strengt;
        

        /// <summary>
        /// <int> Atribut </int>
        /// |
        /// <int> Bonus </int>
        /// </summary>
        public ValueTuple<int,int> Strengt 
        { 
            get=> strengt; 
            set 
            { strengt.Item1 = value.Item1;
              strengt.Item2 = value.Item2 == 0 ? AtributBonus[value.Item1] : value.Item2; 
            } 
        }        //15+2   // (Cz: Síla) 
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


        public AtributEnum PrimaryAtribut_1 { get; set; }  // primary atribute 1 (CZ: primární atribut 1)
        public AtributEnum PrimaryAtribut_2 { get; set; }   // primary atribute 2 (CZ: primární atribut 2)

        public int PrimarValueIndex_1 { get; set; }
        public int PrimarValueIndex_2 { get; set; }


        // final range atributes (CZ: finální rozsah atributů)
        public ValueTuple<int,int> StrengthFinalRange { get; set; }
        public ValueTuple<int,int> AgilityFinalRange { get; set; }
        public ValueTuple<int,int> ConstitutionFinalRange { get; set; }
        public ValueTuple<int,int> IntelligenceFinalRange { get; set; }
        public ValueTuple<int,int> CharismaFinalRange { get; set; }


        // ----------------------- NOT SAVE TO DATABASE-------------------

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
            [18] = 4,
            [19] = 4,
            [20] = 5,
            [21] = 5,
            [22] = 6,
            [23] = 7,
            [24] = 7,
            [25] = 8,
            [26] = 8,
            [27] = 9,
            [28] = 9,
            [29] = 10,
            [30] = 10,
        };

        [NotMapped] public string strengthLabel = "Síla";
        [NotMapped] public string agilityLabel = "Obratnost";
        [NotMapped] public string constitutionLabel = "Odolnost";
        [NotMapped] public string intelligenceLabel = "Inteligence";
        [NotMapped] public string charismaLabel = "Charisma";

        [NotMapped] private int[] primaryStrength = new[] { 11,13 };
        [NotMapped] private int[] primaryAgility = new[] { 13,14 };
        [NotMapped] private int[] primaryConstitution = new[] { 12,13 };
        [NotMapped] private int[] primaryIntelligence = new[] { 13,14 };
        [NotMapped] private int[] primaryCharisma = new[] { 12,13 };


        public void SetAllPrimaryAtributes(RaceDto raceData)
        {
            SetDefaultAtributeAsRaceRange(raceData);
            SetOnePrimaryAtribut(PrimaryAtribut_1,PrimarValueIndex_1,raceData);
            SetOnePrimaryAtribut(PrimaryAtribut_2,PrimarValueIndex_2,raceData);
        }
        public Dictionary<AtributEnum,string> GetBaseAtributesDictionary()
        {
            Dictionary<AtributEnum,string> baseAtributesDictionary = new();

            baseAtributesDictionary.Add(AtributEnum.strength,strengthLabel);
            baseAtributesDictionary.Add(AtributEnum.agility,agilityLabel);
            baseAtributesDictionary.Add(AtributEnum.constitution,constitutionLabel);
            baseAtributesDictionary.Add(AtributEnum.intelligence,intelligenceLabel);
            baseAtributesDictionary.Add(AtributEnum.charisma,charismaLabel);
            return baseAtributesDictionary;
        }
        public List<int> GetValuesForPrimaryAtrubute_Selector(AtributEnum atribut)
        {
            List<int> rangeSelectedAtrubute = new List<int>(); //support List

            switch(atribut)
            {
                case AtributEnum.strength: rangeSelectedAtrubute = primaryStrength.ToList(); break;
                case AtributEnum.agility: rangeSelectedAtrubute = primaryAgility.ToList(); break;
                case AtributEnum.constitution: rangeSelectedAtrubute = primaryConstitution.ToList(); break;
                case AtributEnum.intelligence: rangeSelectedAtrubute = primaryIntelligence.ToList(); break;
                case AtributEnum.charisma: rangeSelectedAtrubute = primaryCharisma.ToList(); break;
            }
            return rangeSelectedAtrubute.ToList();
        }




        private void SetOnePrimaryAtribut(AtributEnum atribute,int primaryIndex,RaceDto race)
        {
            switch(atribute)
            {
                case AtributEnum.strength: StrengthFinalRange = (primaryStrength[primaryIndex] + race.Strength_Corection, primaryStrength[primaryIndex] + race.Strength_Corection + 5); break;
                case AtributEnum.agility: AgilityFinalRange = (primaryAgility[primaryIndex] + race.Agility_Corection, primaryAgility[primaryIndex] + race.Agility_Corection + 5); break;
                case AtributEnum.constitution: ConstitutionFinalRange = (primaryConstitution[primaryIndex] + race.Constitution_Corection, primaryConstitution[primaryIndex] + race.Constitution_Corection + 5); break;
                case AtributEnum.intelligence: IntelligenceFinalRange = (primaryIntelligence[primaryIndex] + race.Intelligence_Correction, primaryIntelligence[primaryIndex] + race.Intelligence_Correction + 5); break;
                case AtributEnum.charisma: CharismaFinalRange = (primaryCharisma[primaryIndex] + race.Charisma_Correction, primaryCharisma[primaryIndex] + race.Charisma_Correction + 5); break;
            }
        }
        private void SetDefaultAtributeAsRaceRange(RaceDto raceData)
        {
            StrengthFinalRange = (raceData.Strength, raceData.Strength_Max);
            AgilityFinalRange = (raceData.Agility, raceData.Agility_Max);
            ConstitutionFinalRange = (raceData.Constitution, raceData.Constitution_Max);
            IntelligenceFinalRange = (raceData.Intelligence, raceData.Intelligence_Max);
            CharismaFinalRange = (raceData.Charisma, raceData.Charisma_Max);
        }




        //------------------ DICE ROLLS----------------
        
        
        
        public int Strength_DiceRoll { get => ((StrengthFinalRange.Item2 - StrengthFinalRange.Item1) / 5); }
        public int Agility_DiceRoll { get => ((AgilityFinalRange.Item2 - AgilityFinalRange.Item1) / 5); }
        public int Constitution_DiceRoll { get => ((ConstitutionFinalRange.Item2 - ConstitutionFinalRange.Item1) / 5); }
        public int Intelligence_DiceRoll { get => ((IntelligenceFinalRange.Item2 - IntelligenceFinalRange.Item1) / 5); }
        public int Charisma_DiceRoll { get => ((CharismaFinalRange.Item2 - CharismaFinalRange.Item1) / 5); }


        public int NumberOfDiceRolls()
        {
            return ((StrengthFinalRange.Item2 - StrengthFinalRange.Item1) / 5)
            + ((AgilityFinalRange.Item2 - AgilityFinalRange.Item1) / 5)
            + ((ConstitutionFinalRange.Item2 - ConstitutionFinalRange.Item1) / 5)
            + ((IntelligenceFinalRange.Item2 - IntelligenceFinalRange.Item1) / 5)
            + ((CharismaFinalRange.Item2 - CharismaFinalRange.Item1) / 5)
            + 1  // prifipoint (Cz: profibody)
            + 1; // appearance (Cz: vzhled)
        } // (Cz: počet hodů kostkou 1k6)



















    }
}
