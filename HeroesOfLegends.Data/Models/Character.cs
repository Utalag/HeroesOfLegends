

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
        public string Name { get; set; } = string.Empty; // character name (Cz: Jméno postavy)
        public string Description { get; set; } = string.Empty; // charatcer description (Cz: Popis postavy)
        public int RaceId { get; set; } // Race ID (Cz: Rasa)
        public int ProfessionId { get; set; }


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




        //---------------------------------------------  VÝBĚR PROMÁRNÍCH DOVEDNOSTÍ  -----------
        //private bool strength_bool = false;
        //private bool agility_bool = false;
        //private bool intelligence_bool = false;
        //private bool charisma_bool = false;
        //private bool constitution_bool = false;

        //public bool Strength_bool { get => strength_bool; set { AtributeConfigBool.Add(value); strength_bool = value; } }
        //public bool Agility_bool { get => agility_bool; set { AtributeConfigBool.Add(value); agility_bool = value; } }
        //public bool Intelligence_bool { get => intelligence_bool; set { AtributeConfigBool.Add(value); intelligence_bool = value; } }
        //public bool Charisma_bool { get => charisma_bool; set { AtributeConfigBool.Add(value); charisma_bool = value; } }
        //public bool Constitution_bool { get => constitution_bool; set { AtributeConfigBool.Add(value); constitution_bool = value; } }
        //public List<bool> AtributeConfigBool { get; set; } = new List<bool>();


        //public int ManaWizard { get => (Professions.ManaWizardBool) ? QuantityManaWizard(Professions.Level,Intelligence) : 0; }
        //public int ManaAlchemist { get => (Professions.ManaAlchemistBool) ? QuantityManaAlchemist(Professions.Level,Agility) : 0; }
        //public int ManaRenger { get => (Professions.ManaRengerBool) ? QuantityManaRenger(Professions.Level,Intelligence) : 0; }



        //        /// <summary>
        //        /// výpočet Max síly
        //        /// </summary>
        //        /// <param name="atribut"></param>
        //        /// <param name="diceroll"></param>
        //        /// <returns></returns>
        //        private int AtributMax(int atribut,int diceRoll)
        //        {

        //            return (atribut != 0) ? (atribut - diceRoll + 6) : 0;
        //        }
        //        private int AtributMin(int atribut,int diceRoll)
        //        {

        //            return (atribut != 0) ? (atribut - diceRoll + 1) : 0;
        //        }
        //        /// <summary>
        //        /// Vypsání many podle levlu a inteligence
        //        /// </summary>
        //        /// <param name="levl"></param>
        //        /// <param name="atribut">stupeň inteligence</param>
        //        /// <returns></returns>
        //        public int QuantityManaWizard(int levl,int atribut)
        //        {
        //            int[,] wizard = new int[,]
        //                    {
        //	  //levl 1  2  3  4  5	  INT
        //			{7,10,12,14,17 }, // 8
        //			{7,10,12,14,17 }, // 9
        //			{7,11,14,17,20 }, // 10
        //			{7,11,14,17,20 }, // 11
        //			{8,12,15,19,22 }, // 12
        //			{8,12,15,19,22 }, // 13
        //			{8,12,16,20,24 }, // 14
        //			{8,12,16,20,24 }, // 15
        //			{8,12,17,21,26 }, // 16
        //			{8,12,17,21,26 }, // 17
        //			{9,13,18,23,28 }, // 18
        //			{9,13,18,23,28 }, // 19
        //			{9,14,20,26,31 }, // 20
        //			{9,14,20,26,31 }, // 21
        //					};

        //            if(atribut < 8)     // omezeno na atibut max 8
        //                atribut = 8;
        //            if(atribut < 21)
        //                atribut = 21;

        //            if(levl > 5)            // omezeno na 5 úroveň 
        //                levl = 5;
        //            if(levl < 0)
        //                levl = 1;
        //            return wizard[atribut - 8,levl - 1];
        //        }
        //        /// <summary>
        //        /// Vypsání many podle levlu a inteligence
        //        /// </summary>
        //        /// <param name="levl"></param>
        //        /// <param name="atribut">stupeň Inteligence</param>
        //        /// <returns></returns>
        //        public int QuantityManaRenger(int levl,int atribut)
        //        {
        //            int[,] renger = new int[,]
        //{
        //	  //levl 1  2  3  4  5	  INT
        //			{0,3,6,10,12 }, // 6
        //			{0,3,6,10,12 }, // 7
        //			{0,3,6,10,13 }, // 8
        //			{0,3,6,10,13 }, // 9
        //			{0,3,7,11,13 }, // 10
        //			{0,3,7,11,13 }, // 11
        //			{0,3,7,11,14 }, // 12
        //			{0,3,7,11,14 }, // 13
        //			{0,3,7,11,15 }, // 14
        //			{0,3,7,11,15 }, // 15
        //			{0,3,8,12,15 }, // 16
        //			{0,3,8,12,15 }, // 17
        //			{0,3,8,13,16 }, // 18
        //			{0,3,8,13,16 }, // 19
        //};
        //            if(atribut < 6)     // omezeno na atibut max 8
        //                atribut = 6;
        //            if(atribut < 19)
        //                atribut = 19;

        //            if(levl > 5)            // omezeno na 5 úroveň 
        //                levl = 5;
        //            if(levl < 0)
        //                levl = 1;
        //            return renger[atribut - 6,levl - 1];
        //        }
        //        /// <summary>
        //        /// Vypsání many podle levlu a obratnosti
        //        /// </summary>
        //        /// <param name="levl"></param>
        //        /// <param name="atribut">stupeň obratnosti</param>
        //        /// <returns></returns>
        //        public int QuantityManaAlchemist(int levl,int atribut)
        //        {
        //            int[,] alchemist = new int[,]
        //            {
        //	  //levl 1  2  3  4  5	  INT
        //			{7,15,31,62,126}, // 8
        //			{7,15,31,62,126}, // 9
        //			{7,16,35,70,131}, // 10
        //			{7,16,35,70,131}, // 11
        //			{8,17,38,76,142}, // 12
        //			{8,17,38,76,142}, // 13
        //			{8,18,40,80,150}, // 14
        //			{8,19,42,84,158}, // 15
        //			{8,19,42,84,158}, // 16
        //			{9,20,45,90,169}, // 17
        //			{9,20,45,90,169}, // 18
        //			{9,21,49,98,184}, // 19
        //			{9,21,49,98,184}, // 20
        //			};
        //            if(atribut < 8)     // omezeno na atibut max 8
        //                atribut = 8;
        //            if(atribut < 20)
        //                atribut = 20;

        //            if(levl > 5)            // omezeno na 5 úroveň 
        //                levl = 5;
        //            if(levl < 0)
        //                levl = 1;
        //            return alchemist[atribut - 8,levl - 1];
        //        }
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
