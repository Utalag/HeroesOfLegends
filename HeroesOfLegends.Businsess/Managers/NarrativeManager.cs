using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class NarrativeManager : GenericManager<NarrativeDto,Narrative>, INarrativeManager
    {
        private readonly INarrativeRepository repository;

        public NarrativeManager(HoLDbContext db,ILogger<DbSet<NarrativeDto>> logger,INarrativeRepository repository) : base(db,logger)
        {
            this.repository = repository;
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
