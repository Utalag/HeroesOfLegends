namespace HeroeOfLegends.Businsess.Models
{
    public class ProfessionDto
    {


        public int ProfessionId { get; set; }
        public string Name { get; set; } = string.Empty;            // [Display (Name = "Základní povolání")]
        public string Description { get; set; } = string.Empty;     // [Display (Name = "Popis")]
        public int Level { get; set; }


        public int RaceId { get; set; }
        /// <summary>
        /// Hodnota pro zobrazení nebo skrytí talčítka na přidání životů
        /// </summary>
        public bool HpAllDiceRolls { get; set; } = true;
        public int Hp { get; set; }
        /// <summary>
        /// 1-4 body do na volbu životů
        /// </summary>
        public int HpPointeded { get; set; }
        public List<int> GetHpDiceRoll { get; set; }
        /// <summary>
        /// Počet profibodl pro výběrprofesních dovedností
        /// </summary>
        /// /// <summary>
        /// rozdah profibodů (1k6), výchozí hodnota 4
        /// </summary>
        public int GetProfessionPointedDiceRoll { get; set; }
        /// <summary>
        /// 1-4 body a výstupem bude součet vlastností 24-27
        /// </summary>
        public int AtributePointed { get; set; }
        /// <summary>
        ///  počet bodů pro system výběru podle levlových bloků ( GenerateSystem.group)
        /// </summary>
        public int LevelGroupFreePoint { get; set; }
        /// <summary>
        /// počet bodů pro system výběru podle přiřazovaných bodů ( GenerateSystem.level)
        /// </summary>
        public int LevelFreePointed { get; set; }


        //------------------------------------------  OTEVŘE VÝBĚR MAGICKÝCH SCHOPNOSTÍ ----------
        /// <summary>
        /// povolí kouzelnickou manu
        /// </summary>
        public bool ManaWizardBool { get; set; } = false;
        /// <summary>
        /// povolí Alchymistickou manu
        /// </summary>
        public bool ManaAlchemistBool { get; set; } = false;
        /// <summary>
        /// povolí hraničářskou manu
        /// </summary>
        /// 
        public bool ManaRengerBool { get; set; } = false;






        //public IList<string>? CharacterNames { get; set; }

        //public IList<string> RaceNames { get; set; }

    }
}


