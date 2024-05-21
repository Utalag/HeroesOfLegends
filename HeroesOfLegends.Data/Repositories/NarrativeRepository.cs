using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Data.Repositories
{
    public class NarrativeRepository : GenericCRUD<Narrative,HoLDbContext>, INarrativeRepository
    {
        public NarrativeRepository(HoLDbContext db) : base(db)
        {
        }

        public IList<Narrative> FindAllByNames(IEnumerable<string> names)
        {
            return dbSet.Where(x => names.Contains(x.NarrativeName)).ToList();
        }
    }
}
