namespace HeroeOfLegends.Data.Interfaces
{
    public interface IProfession
    {

        public int Level { get; }
        public int Hp { get; }


        public bool ManaWizardBool { get; }
        public bool ManaAlchemistBool { get; }
        public bool ManaRengerBool { get; }


        public int ProfessionPoint { get; }


        // HP-----
        public List<int> GetHpDiceRoll { get; }



        /// <summary>
        /// Celkový součet minim primárvích dovedností
        /// </summary>
        public int AtributePointed { get; }
    }
}