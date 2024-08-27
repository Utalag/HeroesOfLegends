﻿using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Data.Repositories
{
    public class RaceRepository : GenericCRUD<Race,HoLDbContext>, IRaceRepository
    {
        public RaceRepository(HoLDbContext db) : base(db)
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
