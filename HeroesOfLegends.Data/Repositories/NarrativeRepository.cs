using HeroeOfLegends.Data.Interfaces;
using HeroeOfLegends.Models;

namespace HeroeOfLegends.Data.Repositories
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
