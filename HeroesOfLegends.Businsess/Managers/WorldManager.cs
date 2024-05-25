using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Businsess.Managers
{
    public class WorldManager : IWorldManager
    {
        private readonly IWorldRepository worldRepository;
        private readonly IRaceRepository raceRepository;
        private readonly INarrativeRepository narrativeRepository;
        private readonly IMapper mapper;

        public WorldManager(IWorldRepository worldRepository,
            IRaceRepository raceRepository,
            INarrativeRepository narrativeRepository,
            IMapper mapper)
        {
            this.worldRepository = worldRepository;
            this.raceRepository = raceRepository;
            this.narrativeRepository = narrativeRepository;
            this.mapper = mapper;
        }


        public IList<WorldDto> GetSelectedWorld(int page = 0,int pageSize = int.MaxValue)
        {
            //List monster napním všemi monstry
            IList<World> world = worldRepository.Page(page,pageSize);

            // vrátí list přemapovaný na MonsterDro
            return mapper.Map<IList<WorldDto>>(world);
        }


        public IList<WorldDto> GetAllWorld()
        {
            IList<World> worlds = worldRepository.All();
            return mapper.Map<IList<WorldDto>>(worlds);
        }


        public WorldDto AddWorld(WorldDto worldDto)
        {
            World world = mapper.Map<World>(worldDto);
            world.Races.AddRange(raceRepository.FindAllByIds(worldDto.RaceIds));
            world.Narratives.AddRange(narrativeRepository.FindAllByNames(worldDto.NarrativesNames));

            return mapper.Map<WorldDto>(worldRepository.Insert(world));
        }


    }
}
