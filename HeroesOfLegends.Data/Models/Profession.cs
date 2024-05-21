using HeroeOfLegends.Data.Interfaces;

namespace HeroeOfLegends.Models
{
    public enum GenerateSystem
    {
        group,  // výběr dovedností po blocích 1-5/6-15/16-36
        level   // výběr dovedností podle přidělených bodů
    }

    public class Profession : IProfession
    {
        public int ProfessionId { get; set; }
        public string Name { get; set; } = string.Empty;            // [Display (Name = "Základní povolání")]
        public string Description { get; set; } = string.Empty;     // [Display (Name = "Popis")]
        public int Level { get; set; } = 1;




        //-----------------------------------------------------------  VAZBY  ---------------
        public virtual IList<Narrative> Narratives { get; set; } = new List<Narrative>();


        public virtual IList<Character> Character { get; set; } = new List<Character>();


        //----------------------------------------------------------   HP   ---------------
        private int hpPointeded = 1;
        private int hpRangeBase;    // 1k6 / 1k10
        private int hpBonus;        // + 0 až 2
        private int hpExpert;       // od 10 úrovně
        public List<int> GetHpDiceRoll { get; set; } = new();
        /// <summary>
        /// Hodnota pro zobrazení nebo skrytí talčítka na přidání životů
        /// </summary>
        public bool HpAllDiceRolls { get; set; } = true;
        public int Hp { get => HpCurrent(); }
        /// <summary>
        /// vypočítá životy podle množsví hodů
        /// </summary>
        /// <returns></returns>
        private int HpCurrent()
        {
            int SumHp = 0;
            foreach(int roll in GetHpDiceRoll)
            {
                if(Level < 10)
                    SumHp += roll + hpBonus;
                else
                    SumHp += hpExpert;
            }
            return SumHp;
        }
        /// <summary>
        /// přidání hodu kostkou na životy !!TLAČÍTKO!!
        /// </summary>
        /// <param name="diceRoll"></param>
        public void HpAddDiceRoll(int diceRoll)
        {
            try
            {
                if(Level > GetHpDiceRoll.Count)
                {
                    HpAllDiceRolls = true;
                    GetHpDiceRoll.Add(diceRoll);
                    HpCurrent();
                }
            }
            catch
            {

                HpAllDiceRolls = false;
            }


        }
        /// <summary>
        /// 1-4 body do na volbu životů
        /// </summary>
        public int HpPointeded
        {
            get
            {
                return hpPointeded;
            }
            set
            {
                if(value == 0)
                    hpPointeded = 1;
                else if(value > 4)
                    hpPointeded = 4;
                else if(value < 1)
                    hpPointeded = 1;
                else
                    hpPointeded = value;

                switch(hpPointeded)
                {
                    case 1: { hpRangeBase = 6; hpBonus = 0; hpExpert = 1; GetHpDiceRoll.Add(6); }; break;
                    case 2: { hpRangeBase = 6; hpBonus = 1; hpExpert = 1; GetHpDiceRoll.Add(6); }; break;
                    case 3: { hpRangeBase = 6; hpBonus = 2; hpExpert = 2; GetHpDiceRoll.Add(6); }; break;
                    case 4: { hpRangeBase = 10; hpBonus = 0; hpExpert = 2; GetHpDiceRoll.Add(10); }; break;
                    //case 1: { ResetHP(); hpRangeBase = 6; hpBonus = 0; hpExpert = 1; hpRoll.Add(6); }; break;
                    //case 2: { ResetHP(); hpRangeBase = 6; hpBonus = 1; hpExpert = 1; hpRoll.Add(6); }; break;
                    //case 3: { ResetHP(); hpRangeBase = 6; hpBonus = 2; hpExpert = 2; hpRoll.Add(6); }; break;
                    //case 4: { ResetHP(); hpRangeBase = 10; hpBonus = 0; hpExpert = 2; hpRoll.Add(10); }; break;
                }

            }

        }
        public void ResetHP()
        {
            foreach(int hp in GetHpDiceRoll)
            {
                if(GetHpDiceRoll.Count > 1)
                    GetHpDiceRoll.Remove(hp);
            }
            HpCurrent();
        }


        //---------------------------------------------------------  PROFIBODY  --------------
        private int atributePointed;
        private int professionPoint;
        public int GetProfessionPointedDiceRoll { get; set; }



        /// <summary>
        /// 1-4 body a výstupem bude součet vlastností 24-27
        /// </summary>
        public int AtributePointed
        {
            get => atributePointed;
            set
            {
                switch(value)
                {
                    case 1: { atributePointed = 24; }; break;
                    case 2: { atributePointed = 25; }; break;
                    case 3: { atributePointed = 26; }; break;
                    case 4: { atributePointed = 27; }; break;
                    default: { atributePointed = 24; }; break;
                }
            }
        }


        /// <summary>
        /// 1k6 Počet profibodl pro výběrprofesních dovedností
        /// </summary>
        /// /// <summary>
        /// rozdah profibodů (1k6), výchozí hodnota 4
        /// </summary>
        public int ProfessionPoint
        {
            get
            {
                return professionPoint;
            }
            set
            {
                switch(value)
                {
                    case 1: { professionPoint = 18; }; break;
                    case 2: { professionPoint = 19; }; break;
                    case 3: { professionPoint = 20; }; break;
                    case 4: { professionPoint = 21; }; break;
                    case 5: { professionPoint = 22; }; break;
                    case 6: { professionPoint = 23; }; break;
                    default: { professionPoint = 20; }; break;
                }
                GetProfessionPointedDiceRoll = value;
            }
        }
        /// <summary>
        ///  počet bodů pro system výběru podle levlových bloků ( GenerateSystem.group)
        /// </summary>
        public int LevelGroupFreePoint
        {
            get => ProfessionPoint - hpPointeded - (AtributePointed - 23);
        }
        /// <summary>
        /// počet bodů pro system výběru podle přiřazovaných bodů ( GenerateSystem.level)
        /// </summary>
        public int LevelFreePointed
        {
            get
            {
                if(Level >= 6)
                    return (LevelGroupFreePoint * 5) + ((Level - 5) * ProfessionPoint);
                else
                    return LevelGroupFreePoint * Level;
            }
        }


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



        //-----------------------------------------------  OSTATNI  ------------------------------

        ///// <summary>
        ///// Šance na úspěch %
        ///// </summary>
        //public Dictionary<int,int> ChancesOfSuccess { get; set; } = new Dictionary<int,int>()
        //{
        //	{6,25},{7,25},{8,32},{9,32},{10,47},{11,47},{12,47},{13,61},{14,61},{15,74},{16,74},{17,85},{18,85},{19,95},{20,95},{21,99}
        //};

        ///// <summary>
        ///// Vypíše počet kouzel kouzelníka
        ///// </summary>
        //public int SplellsMany { get=> (ManaWizardBool)? SpellsMany[Level]:0; }

        ///// <summary>
        ///// Počet kouzel podle úrovně nebo podle bodů
        ///// </summary>
        //public Dictionary<int,int> SpellsMany { get; set; } = new Dictionary<int,int>()
        //{
        //	{1,3},{2,5},{3,7},{4,9},{5,11}
        //};


        public void LevelUp()
        {
            ++Level;

            if(Level >= 10)
            {
                HpAllDiceRolls = true;  // po 9levlu talčítko na přidání životů nebude již fungovat 
                HpAddDiceRoll(0);       // po 9 levlu už nepřibyde žádný hod kostkou
            }
            else
                HpAllDiceRolls = false; // na 1-9 levlu se aktivuje tlačítko po zvýšení levlu
        }
        public void LevelDown()
        {
            --Level;
            if(Level < GetHpDiceRoll.Count)
            {
                HpAllDiceRolls = true;
                GetHpDiceRoll.Remove(GetHpDiceRoll.Last());
                HpCurrent();
            }
            else if(Level == GetHpDiceRoll.Count)
                HpAllDiceRolls = true;
            else
                HpAllDiceRolls = false;


        }


        /// <summary>
        /// Inicializace testovacích dat
        /// </summary>
        /// <returns></returns>
        public Profession[] Initial()
        {
            var data = new Profession[]
            {
                new (){
                HpPointeded         =4,
                ProfessionId        =1,
                Name                ="Válečník",
                Description         ="Válečník je silný a houževnatý. Vládne mnoha druhy zbraní a umí se v jejich používání zdokonalovat. V boji má větší šanci, že nepřítele zasáhne. A vzhledem k tomu, že bitvy a souboje jsou v Dračím doupěti běžné, je pro každou družinu nezbytné, aby ve svém středu měla jednoho nebo více válečníků. Postavy jiných povolání sice také mohou bojovat, ale mohou být svázány rozličnými omezeními. Válečníci jsou jediní, kteří boj skutečně studují a mají v něm některé výhody, které žádné jiné povolání nemá.",
                ProfessionPoint     =1,
                AtributePointed     =2,
                Level               =3


                },

                new (){
                ProfessionId        =2,
                Name                ="Hraničář",
                Description         ="Hraničář je silný a moudrý. Zná přírodu a tvory, kteří ji obývají, a umí svých znalostí využívat. V boji má určitá omezení, ale stále může být platným bojovníkem po boku válečníka. Kromě toho je vhodný jako silná zadní stráž v družinách, které nemají dost válečníků (a takových družin bude většina).\r\nHraničáři zpravidla žijí v hlubokých hvozdech, kde sami, jen se svými psy, střeží stezky a pomáhají těm, kdo pomoc potřebují. Proto jsou takřka všude vítanými hosty. Dlouholetým stykem s přírodou a přírodní magií se u nich vyvíjejí i jisté nadpřirozené schopnosti, které jim pomáhají při jejich nebezpečném a osamoceném životě alespoň tak se to mezi lidmi povídá.\r\nHraničáři se dají přemluvit, aby se připojili k družině. Jsou vynikajícími lovci a stopaři a proto jsou neocenitelní při dobrodružstvích ve volné přírodě. Ale jejich mimořádné schopnosti jsou užitečné i jinde, například v podzemí. V boji i mimo něj je hraničář hodnotným členem každé družiny.\r\n",
                ManaRengerBool      =true,
                HpPointeded         =1,
                ProfessionPoint     =4,
                AtributePointed     =1
                },


                new (){
                ProfessionId        =3,
                Name                ="Alchymista",
                Description         ="Alchymista je šikovný a leccos vydrží. Zabývá se výrobou lektvarů a různých kouzelných předmětů. V boji většinou nepomáhá přímo, ale prostřednictvím svého umění. Alchymisté se liší od kouzelníků svým přístupem k magii. Zatímco kouzelníci rozvíjejí svou inteligenci a z ní získávají magenergii, alchymisté ji destilují z různých předmětů a záleží jen na jejich obratnosti, zda a kolik magenergie se jim z nich podaří vytěžit.\r\nDíky tomu jsou alchymisté bližší \"obyčejným\" lidem než kouzelníci a nevzbuzují u nich strach. Přesto mají svým způsobem mnohem důvěrnější vztah k magenergii než jiná povolání nadaná schopností kouzlit.\r\nAlchymistovy kouzelné předměty mohou být užitečné v mnoha různých situacích. Jejich účinky se často liší od účinků kouzelníkových kouzel a žádná družina neprodělá, když bude mít alchymistu ve svém středu.\r\n",
                ManaAlchemistBool   =true,
                HpPointeded         =2,
                ProfessionPoint     =6,
                AtributePointed     =4
                },


                new (){
                ProfessionId        =4,
                Name                ="Kouzelník",
                Description         ="Kouzelník je chytrý a umí ovlivňovat druhé. Není příliš silný v boji, ale vynahrazuje si to svými zvláštními schopnostmi, zejména studiem kouzel. Kouzelníci byli vždy terčem nejrůznějších dohadů a nikdo vlastně neví, co všechno mohou dokázat. Lidé se k nim chovají uctivě, ale podezřívavě a se strachem. Kouzelníci sami dávají přednost samotě, ve které studují svá kouzla, a stýkají se jenom se svým učitelem.\r\nKouzla jsou přirozenou so částí světa. Jsou předměty, které jsou bezcenné pro někoho, kdo se v kouzlech nevyzná, a které se mohou stát strašnou zbraní v rukou mága.\r\nŘadu situaci je mnohem lehčí vyřešit pomoci kouzla než obvyklým způsobem. Ale pozor! Nejde to vždy a zvláště zpočátku jsou kouzla spíše vzácná.\r\nPro své mimořádné schopnosti je kouzelník vyhledávaným členem každé družiny. Je pravda, že většinu času alespoň zpočátku - zůstávají tyto schopnosti nevyužity, ale okamžik, kdy je použije, může znamenat rozhodující zvrat v celém dobrodružství.\r\n",
                ManaWizardBool      =true,
                HpPointeded         =1,
                ProfessionPoint     =2,
                AtributePointed     =1
                },

                new (){
                ProfessionId        =5,
                Name                ="Zloděj",
                Description         ="Zloděj je mrštný a umí se vloudit do přízně jiných lidí. V boji zpravidla nestojí v první řadě a není to ani jeho poslání, ale dokáže i tvrdě zasáhnout.\r\nZloději jsou odborníky na nebezpečné situace, které vyžadují vtip a obratnost místo hrubé síly. Zloději studují své řemeslo v obávaném zlodějském cechu a prostí lidé si vyprávějí bájné zkazky o jejich umění. O zlodějích, kteří sami pronikli do přísně střežených pevností nebo zakletých hrobek a ukradli královské poklady, o zlodějích, kteří unikli z okovů v podzemním žaláři, hlídaném těmi nejlepšími z královské gardy.\r\nZloději z pochopitelných důvodů jen neradi odhalují svou profesi. Dokážou být velice zábavní společníci, snadno si získají přízeň jiných lidí a zjisti tak množství zajímavých informaci. Ty pak využijí ke svému prospěchu, nebo k prospěchu družiny.\r\nDíky svým pozoruhodným schopnostem, které nemá žádné jiné povolání, je zloděj žádaným členem v každé družině. Postavám, se kterými půjde, ušetří mnoho nesnází.\r\n",
                HpPointeded         =1,
                ProfessionPoint     =3,
                AtributePointed     =2
                },
            };
            return data;
        }
    }
}

/*
		[Display(Name = "Síla")]
		[Range(1,4,ErrorMessage = "Zadej hodnotu v rozsahu 1-4")]
		public int Strength
		{
			get => strength;
			set => strength = Strength_bool ? 10 + value : 0 ;

		}

		[Display(Name = "Obratnost")]
		[Range(1,4,ErrorMessage = "Zadej hodnotu v rozsahu 1-4")]
		public int Agility
		{
			get => agility;
			set => agility = Agility_bool ? 10 + value : 0;
		}

		[Display(Name = "Odolnost")]
		[Range(1,4,ErrorMessage = "Zadej hodnotu v rozsahu 1-4")]
		public int Constitution
		{
			get => constitution;
			set => constitution = Constitution_bool ? 10 + value : 0;
		}

		[Display(Name = "Inteligence")]
		[Range(1,4,ErrorMessage = "Zadej hodnotu v rozsahu 1-4")]
		public int Intelligence
		{
			get => intelligence;
			set => intelligence = Intelligence_bool ? 10 + value : 0;
		}

		[Display(Name = "Charsisma")]
		[Range(1,4,ErrorMessage = "Zadej hodnotu v rozsahu 1-4")]
		public int Charisma
		{
			get => charisma;
			set => charisma = Charisma_bool ? 10 + value : 0;
		}

		public int Strength_Max { get => AtributMax(Strength); }
		public int Agility_Max { get => AtributMax(Agility); }
		public int Constitution_Max { get => AtributMax(Constitution); }
		public int Intelligence_Max { get => AtributMax(Intelligence); }
		public int Charisma_Max { get => AtributMax(Charisma); }

		public int ManaWizard { get=>(ManaWizardBool) ? QuantityManaWizard(Level,Intelligence) : 0; }
		public int ManaAlchemist { get => (ManaAlchemistBool) ? QuantityManaAlchemist(Level,Agility) : 0; }
		public int ManaRenger { get => (ManaRengerBool) ? QuantityManaRenger(Level,Intelligence) : 0; }

		/// <summary>
		/// výpočet Max síly
		/// </summary>
		/// <param name="min"></param>
		/// <param name="diceroll"></param>
		/// <returns></returns>
		private int AtributMax(int min)
		{
			return (min != 0) ? (min + 5) : 0;
		}

		// sestaveno jinak
		public int AtributePointed
		{
			get
			{
				switch(Strength + Agility + Constitution + Intelligence + Charisma)
				{
					case 23: { atributePointed = 1; }; break;
					case 24: { atributePointed = 1; }; break;
					case 25: { atributePointed = 2; }; break;
					case 26: { atributePointed = 3; }; break;
					case 27: { atributePointed = 4; }; break;
					case 28: { atributePointed = 4; }; break;
				}
				return atributePointed;
			}
			set
			{

			}
			}



		-------------MANA-----------
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

		*/

/*
 * přidat třídy 
 * 
 * Základní dělení podel povolýní 
 * dovednostem přiřadit podkategorie  ( lov, kouzlení, alchymie, boj , ostatní
 * 
 */