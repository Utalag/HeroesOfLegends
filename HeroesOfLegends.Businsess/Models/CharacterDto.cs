namespace HeroesOfLegends.Businsess.Models
{
    public class CharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RaceId { get; set; }
        public int ProfessionId { get; set; }  //??
                                               //public virtual Profession Professions { get; set; }


        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        //public int Mobility { get; } // implementovat vypočet


        public int St_DiceRoll { get; set; }
        public int Ag_DiceRoll { get; set; }
        public int Co_DiceRoll { get; set; }
        public int In_DiceRoll { get; set; }
        public int Cha_DiceRoll { get; set; }


        // 4-7 bodů
        /// <summary>
        /// 1-4 body do Síly
        /// </summary>
        public int St_Primar { get; set; }
        /// <summary>
        /// 1-4 body do Obratnosti
        /// </summary>
        public int Ag_Primar { get; set; }
        /// <summary>
        /// 1-4 body do Odolnosti
        /// </summary>
        public int Co_Primar { get; set; }
        /// <summary>
        /// 1-4 body do Inteligence
        /// </summary>
        public int In_Primar { get; set; }
        /// <summary>
        /// 1-4 body do Charismy
        /// </summary>
        public int Cha_Primar { get; set; }




        public int Strength_Max { get; set; }
        public int Agility_Max { get; set; }
        public int Constitution_Max { get; set; }
        public int Intelligence_Max { get; set; }
        public int Charisma_Max { get; set; }

        public int Strength_Min { get; set; }
        public int Agility_Min { get; set; }
        public int Constitution_Min { get; set; }
        public int Intelligence_Min { get; set; }
        public int Charisma_Min { get; set; }

        public bool St_bool { get; set; }
        public bool Ag_bool { get; set; }
        public bool Int_bool { get; set; }
        public bool Cha_bool { get; set; }
        public bool Con_bool { get; set; }
    }
}
