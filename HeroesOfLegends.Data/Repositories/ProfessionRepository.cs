using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Repositories;
using HeroesOfLegends.Models;
using System.Data;

namespace HeroesOfLegends.Data.Repositories
{
    public class ProfessionRepository : GenericCRUD<Profession,HoLDbContext>, IProfessionRepository
    {
        public ProfessionRepository(HoLDbContext db) : base(db)
        {

        }

        public IList<Profession> FindAllByIds(IEnumerable<int> ids)
        {
            return dbSet.Where(x => ids.Contains(x.ProfessionId)).ToList();
        }

        public Profession FindIds(int ids)
        {
            return dbSet.Where(x => x.ProfessionId == ids).First();
        }
    }
}
