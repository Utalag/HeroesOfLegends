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

        //-----CUSTOM METHOD-----//
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
        /// Find all entities with ID
        /// </summary>
        /// <param name="id">id racey</param>
        /// <returns>RaceDto entity</returns>
        public RaceDto? GetRace(int id)
        {
            Race? race = raceRepository.FindById(id);
            if(race is null)
                return null;
            return mapper.Map<RaceDto>(race);
        }

        /// <summary>
        /// Async - Insert new Race entity
        /// </summary>
        /// <param name="raceDto">RaceDto</param>
        /// <returns>RaceDto</returns>
        public RaceDto AddRace(RaceDto raceDto)
        {
            Race race = mapper.Map<Race>(raceDto); // raceDto map to race
            race.RaceId = default; // id set to default int
            Race addRace = raceRepository.Insert(race); // insert new Race
            return mapper.Map<RaceDto>(addRace); // raturn RaceDto by Mapper
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

        //----- Async CRUD-----//

        public async Task<IList<RaceDto>> GetAllRaceAsync()
        {
            IList<Race> race = await raceRepository.AllAsync();
            return await Task.Run(() => mapper.Map<IList<RaceDto>>(race));
        }

        public async Task<IList<RaceDto>> GetAllRaceAsync(int page = 0,int pageSize = int.MaxValue)
        {
            IList<Race> race = await raceRepository.PageAsync(page,pageSize);
            return await Task.Run(() => mapper.Map<IList<RaceDto>>(race));
        }

        /// <summary>
        /// Asnyc - Find all entities with ID
        /// </summary>
        /// <param name="id">id racey</param>
        /// <returns>RaceDto entity</returns>
        public async Task<RaceDto?> GetRaceAsync(int id)
        {
            Race? race = await raceRepository.FindByIdAsync(id);
            if(race is null)
                return null;
            return await Task.Run(()=>mapper.Map<RaceDto>(race));
        }

        /// <summary>
        /// Async - Insert new Race entity
        /// </summary>
        /// <param name="raceDto">RaceDto</param>
        /// <returns>RaceDto</returns>
        public async Task<RaceDto> AddRaceAsync(RaceDto raceDto)
        {
            Race race = await Task.Run(()=>mapper.Map<Race>(raceDto)); // raceDto map to race
            race.RaceId = default; // id set to default int
            Race addRace = await raceRepository.InsertAsync(race); // insert new Race
            return await Task.Run(()=>mapper.Map<RaceDto>(addRace)); // raturn RaceDto by Mapper
        }

        /// <summary>
        /// Async - Edit entity
        /// </summary>
        /// <param name="raceDto"></param>
        /// <param name="raceId">id</param>
        /// <returns>DtoModel</returns>
        public async Task<RaceDto?> UpdateRaceAsync(RaceDto raceDto,int raceId)
        {
            if(!raceRepository.ExistsWithId(raceId))
            { return null; }
            Race race = await Task.Run(() => mapper.Map<Race>(raceDto)); // raceDto map to race
            race.RaceId = default; // id set to default int
            Race updateRace = await raceRepository.UpdateAsync(race);
            return await Task.Run(()=>mapper.Map<RaceDto>(updateRace));
        }

        /// <summary>
        /// Async - delete entity by id
        /// </summary>
        /// <param name="raceId">id entity</param>
        /// <returns>DtoModel</returns>
        public async Task<RaceDto?> DeleteRaceAsync(int raceId)
        {
            if(!raceRepository.ExistsWithId(raceId))
            { return null; }
            Race? race = await raceRepository.FindByIdAsync(raceId);

            if(race == null)
            { return null; }

            RaceDto raceDto = await Task.Run(()=> mapper.Map<RaceDto>(race));
            await raceRepository.DeleteAsync(raceId);
            return raceDto;
        }
    };
}
