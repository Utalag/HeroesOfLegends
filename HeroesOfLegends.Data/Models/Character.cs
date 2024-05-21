namespace HeroesOfLegends.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RaceId { get; set; }
        public int ProfessionId { get; set; }  //??
        public virtual Profession Professions { get; set; }


        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        //public int Mobility { get; } // implementovat vypočet


        public int St_DiceRoll { get; set; } = 4;
        public int Ag_DiceRoll { get; set; } = 4;
        public int Co_DiceRoll { get; set; } = 4;
        public int In_DiceRoll { get; set; } = 4;
        public int Cha_DiceRoll { get; set; } = 4;


        // 4-7 bodů
        /// <summary>
        /// 1-4 body do Síly
        /// </summary>
        public int St_Primar { get; set; } = 1;
        /// <summary>
        /// 1-4 body do Obratnosti
        /// </summary>
        public int Ag_Primar { get; set; } = 1;
        /// <summary>
        /// 1-4 body do Odolnosti
        /// </summary>
        public int Co_Primar { get; set; } = 1;
        /// <summary>
        /// 1-4 body do Inteligence
        /// </summary>
        public int In_Primar { get; set; } = 1;
        /// <summary>
        /// 1-4 body do Charismy
        /// </summary>
        public int Cha_Primar { get; set; } = 1;


        public int Strength_Min { get => AtributMin(Strength,St_DiceRoll); }
        public int Agility_Min { get => AtributMin(Agility,Ag_DiceRoll); }
        public int Constitution_Min { get => AtributMin(Constitution,Co_DiceRoll); }
        public int Intelligence_Min { get => AtributMin(Intelligence,In_DiceRoll); }
        public int Charisma_Min { get => AtributMin(Charisma,Cha_DiceRoll); }

        public int Strength_Max { get => AtributMax(Strength,St_DiceRoll); }
        public int Agility_Max { get => AtributMax(Agility,Ag_DiceRoll); }
        public int Constitution_Max { get => AtributMax(Constitution,Co_DiceRoll); }
        public int Intelligence_Max { get => AtributMax(Intelligence,In_DiceRoll); }
        public int Charisma_Max { get => AtributMax(Charisma,Cha_DiceRoll); }




        public bool St_bool { get; set; } = true;
        public bool Ag_bool { get; set; } = true;
        public bool Int_bool { get; set; } = false;
        public bool Cha_bool { get; set; } = false;
        public bool Con_bool { get; set; } = false;

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



        /// <summary>
        /// výpočet Max síly
        /// </summary>
        /// <param name="atribut"></param>
        /// <param name="diceroll"></param>
        /// <returns></returns>
        private int AtributMax(int atribut,int diceRoll)
        {

            return (atribut != 0) ? (atribut - diceRoll + 6) : 0;
        }
        private int AtributMin(int atribut,int diceRoll)
        {

            return (atribut != 0) ? (atribut - diceRoll + 1) : 0;
        }
        /// <summary>
        /// Vypsání many podle levlu a inteligence
        /// </summary>
        /// <param name="levl"></param>
        /// <param name="atribut">stupeň inteligence</param>
        /// <returns></returns>
        public int QuantityManaWizard(int levl,int atribut)
        {
            int[,] wizard = new int[,]
                    {
	  //levl 1  2  3  4  5	  INT
			{7,10,12,14,17 }, // 8
			{7,10,12,14,17 }, // 9
			{7,11,14,17,20 }, // 10
			{7,11,14,17,20 }, // 11
			{8,12,15,19,22 }, // 12
			{8,12,15,19,22 }, // 13
			{8,12,16,20,24 }, // 14
			{8,12,16,20,24 }, // 15
			{8,12,17,21,26 }, // 16
			{8,12,17,21,26 }, // 17
			{9,13,18,23,28 }, // 18
			{9,13,18,23,28 }, // 19
			{9,14,20,26,31 }, // 20
			{9,14,20,26,31 }, // 21
					};

            if(atribut < 8)     // omezeno na atibut max 8
                atribut = 8;
            if(atribut < 21)
                atribut = 21;

            if(levl > 5)            // omezeno na 5 úroveň 
                levl = 5;
            if(levl < 0)
                levl = 1;
            return wizard[atribut - 8,levl - 1];
        }
        /// <summary>
        /// Vypsání many podle levlu a inteligence
        /// </summary>
        /// <param name="levl"></param>
        /// <param name="atribut">stupeň Inteligence</param>
        /// <returns></returns>
        public int QuantityManaRenger(int levl,int atribut)
        {
            int[,] renger = new int[,]
{
	  //levl 1  2  3  4  5	  INT
			{0,3,6,10,12 }, // 6
			{0,3,6,10,12 }, // 7
			{0,3,6,10,13 }, // 8
			{0,3,6,10,13 }, // 9
			{0,3,7,11,13 }, // 10
			{0,3,7,11,13 }, // 11
			{0,3,7,11,14 }, // 12
			{0,3,7,11,14 }, // 13
			{0,3,7,11,15 }, // 14
			{0,3,7,11,15 }, // 15
			{0,3,8,12,15 }, // 16
			{0,3,8,12,15 }, // 17
			{0,3,8,13,16 }, // 18
			{0,3,8,13,16 }, // 19
};
            if(atribut < 6)     // omezeno na atibut max 8
                atribut = 6;
            if(atribut < 19)
                atribut = 19;

            if(levl > 5)            // omezeno na 5 úroveň 
                levl = 5;
            if(levl < 0)
                levl = 1;
            return renger[atribut - 6,levl - 1];
        }
        /// <summary>
        /// Vypsání many podle levlu a obratnosti
        /// </summary>
        /// <param name="levl"></param>
        /// <param name="atribut">stupeň obratnosti</param>
        /// <returns></returns>
        public int QuantityManaAlchemist(int levl,int atribut)
        {
            int[,] alchemist = new int[,]
            {
	  //levl 1  2  3  4  5	  INT
			{7,15,31,62,126}, // 8
			{7,15,31,62,126}, // 9
			{7,16,35,70,131}, // 10
			{7,16,35,70,131}, // 11
			{8,17,38,76,142}, // 12
			{8,17,38,76,142}, // 13
			{8,18,40,80,150}, // 14
			{8,19,42,84,158}, // 15
			{8,19,42,84,158}, // 16
			{9,20,45,90,169}, // 17
			{9,20,45,90,169}, // 18
			{9,21,49,98,184}, // 19
			{9,21,49,98,184}, // 20
			};
            if(atribut < 8)     // omezeno na atibut max 8
                atribut = 8;
            if(atribut < 20)
                atribut = 20;

            if(levl > 5)            // omezeno na 5 úroveň 
                levl = 5;
            if(levl < 0)
                levl = 1;
            return alchemist[atribut - 8,levl - 1];
        }
        public Character[] Initial()
        {
            var data = new Character[]
            {
                new Character()
                {
                Id = 1,
                Name = "Bilbo Pytlík",
                Description = "Drobný hobit pocházející z Kraje za Hvozdem.",
                St_Primar = 2,
                Ag_Primar = 2,
                Co_Primar = 2,
                In_Primar=2,
                Cha_Primar = 0,

                ProfessionId = 1,
                RaceId = 1,

                St_bool = true,
                Ag_bool = true,
                Con_bool = false,
                Int_bool = false,
                Cha_bool = false,

                }
            };
            return data;
        }
    }
}
