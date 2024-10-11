using HeroesOfLegends.Data.Interfaces;
using System.Data;
using HeroesOfLegends.Data.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using HeroesOfLegends.Database;

namespace HeroesOfLegends.Data.Repositories
{
    public class ProfessionRepository : GenericCRUD<Profession>, IProfessionRepository
    {
        public ProfessionRepository(HoLDbContext db,ILogger<DbSet<Profession>> logger) : base(db,logger)
        {
        }

        //------ Synchronous methods --------
        public IList<Profession> FindAllByIds(IEnumerable<int> ids)
        {
            return dbSet.Where(x => ids.Contains(x.ProfessionId)).ToList();
        }


        //------ Asynchronous methods --------

        public async Task<IList<Profession>> FindAllByIdsAsync(IEnumerable<int> ids)
        {
            return await Task.Run(() => dbSet.Where(x => ids.Contains(x.ProfessionId)).ToList());
        }

    }


}
