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

        //------ Synchronous methods --------
        public IList<Profession> FindAllByIds(IEnumerable<int> ids)
        {
            return dbSet.Where(x => ids.Contains(x.ProfessionId)).ToList();
        }

    
        //------ Asynchronous methods --------

        public async Task<IList<Profession>> FindAllByIdsAsync(IEnumerable<int> ids)
        {
            return await Task.Run(()=> dbSet.Where(x => ids.Contains(x.ProfessionId)).ToList());
        }

    }


}
