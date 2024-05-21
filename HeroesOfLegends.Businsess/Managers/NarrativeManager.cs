using AutoMapper;
using HeroeOfLegends.Businsess.Interfaces;
using HeroeOfLegends.Businsess.Models;
using HeroeOfLegends.Data.Interfaces;
using HeroeOfLegends.Models;

namespace HeroeOfLegends.Businsess.Managers
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
