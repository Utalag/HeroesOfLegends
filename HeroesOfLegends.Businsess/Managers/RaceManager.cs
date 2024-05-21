using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Businsess.Managers
{
    public class RaceManager : IRaceManager
    {
        private readonly IRaceRepository raceRepository;
        private readonly IMapper mapper;

        public RaceManager(IRaceRepository raceRepository,IMapper mapper)
        {
            this.raceRepository = raceRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// Načte všechny entity
        /// </summary>
        /// <returns>List entit RaceDto</returns>
        public IList<RaceDto> GetAllRace()
        {
            //List monster napním všemi monstry
            IList<Race> race = raceRepository.All();

            // vrátí list přemapovaný na MonsterDro
            return mapper.Map<IList<RaceDto>>(race);
        }


        /// <summary>
        /// našte x entit na n-té stránce
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IList<RaceDto> GetAllRace(int page = 0,int pageSize = int.MaxValue)
        {
            //List monster napním všemi monstry
            IList<Race> race = raceRepository.Page(page,pageSize);

            // vrátí list přemapovaný na MonsterDro
            return mapper.Map<IList<RaceDto>>(race);
        }

        //----- CRUD-----//

        /// <summary>
        /// Vyhledá entitu podle Id
        /// </summary>
        /// <param name="id">id rasy</param>
        /// <returns>RaceDto entita</returns>
        public RaceDto? GetRace(int id)
        {
            Race? race = raceRepository.FindById(id);
            if(race is null)
                return null;
            return mapper.Map<RaceDto>(race);
        }

        /// <summary>
        /// Vložení entity do databáze
        /// </summary>
        /// <param name="raceDto">vsupní entita jako RaceDto</param>
        /// <returns>RaceDto entita</returns>
        public RaceDto AddRace(RaceDto raceDto)
        {
            Race race = mapper.Map<Race>(raceDto); // raceDto namapuju na rasu
            race.RaceId = default; // id nasteveno na defaultní uint
            Race addRace = raceRepository.Insert(race); // vložím monstrum do databze
            return mapper.Map<RaceDto>(addRace); // mapperem vrátím vkládanou entitu jako RaceDto
        }

        /// <summary>
        /// Uprava entity
        /// </summary>
        /// <param name="raceDto">vstupní entita jako MonsterDto</param>
        /// <param name="raceId">id eintity</param>
        /// <returns>vrátí upraenou entitu jako MonsterDto</returns>
        public RaceDto? UpdateRace(RaceDto raceDto,int raceId)
        {
            if(!raceRepository.ExistsWithId(raceId))
                return null;
            Race race = mapper.Map<Race>(raceDto);
            race.RaceId =raceId;
            Race updateRace = raceRepository.Update(race);
            return mapper.Map<RaceDto>(updateRace);
        }

        /// <summary>
        /// smazání entity podel Id
        /// </summary>
        /// <param name="raceId">id entity</param>
        /// <returns>vrací smazanou entitu jako MonsterDto</returns>
        public RaceDto? DeleteRace(int raceId)
        {
            if(!raceRepository.ExistsWithId(raceId))
                return null;
            Race race = raceRepository.FindById(raceId)!;
            RaceDto raceDto = mapper.Map<RaceDto>(race);
            raceRepository.Delete(raceId);
            return raceDto;
        }


    };
}


//V metodě si nejprve z repositáře získáváme seznam všech monster.
//Protože tento seznam obsahuje objekty typu Monster a my chceme, aby
//metoda vracela seznam objektů typu MonsterDto, tak jej musíme
//přemapovat pomocí mapperu. Učinili jsme tak pomocí metody
//Map(), které v generickém parametru předáváme typ výsledného
//objektu.
