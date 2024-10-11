using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using HeroesOfLegends.Database;

namespace HeroesOfLegends.Data.Repositories
{
    public class RaceRepository : GenericCRUD<Race>, IRaceRepository
    {
        public RaceRepository(HoLDbContext db,ILogger<DbSet<Race>> logger) : base(db,logger)
        {
        }

        public IList<Race> FindAllByIds(IEnumerable<int> ids)
        {
            return dbSet.Where(x => ids.Contains(x.RaceId)).ToList();
        }

        public async Task<IList<Race>> FindAllByIdsAsnyc(IEnumerable<int> ids)
        {
            return await Task.Run(()=>dbSet.Where(x => ids.Contains(x.RaceId)).ToList());
        }



    }
}
