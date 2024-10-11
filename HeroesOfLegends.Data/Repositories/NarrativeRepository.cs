using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using HeroesOfLegends.Database;

namespace HeroesOfLegends.Data.Repositories
{
    public class NarrativeRepository : GenericCRUD<Narrative>, INarrativeRepository
    {
        public NarrativeRepository(HoLDbContext db,ILogger<DbSet<Narrative>> logger) : base(db,logger)
        {
        }

        public IList<Narrative> FindAllByNames(IEnumerable<string> names)
        {
            return dbSet.Where(x => names.Contains(x.NarrativeName)).ToList();
        }
    }
}
