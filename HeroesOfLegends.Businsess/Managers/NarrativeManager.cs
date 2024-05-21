using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Businsess.Managers
{
    public class NarrativeManager : INarrativeManager
    {
        private readonly INarrativeRepository repository;
        private readonly IMapper mapper;

        public NarrativeManager(INarrativeRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public IList<string> GetAllName()
        {
            IList<Narrative> narratives = repository.All();
            return mapper.Map<IList<string>>(narratives);

        }

        public IList<NarrativeDto> GetAll()
        {
            IList<Narrative> narratives = repository.All();
            return mapper.Map<IList<NarrativeDto>>(narratives);
        }

    }
}
