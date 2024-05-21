using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Data.Repositories
{
    public class WorldRepository : GenericCRUD<World,HoLDbContext>, IWorldRepository
    {
        public WorldRepository(HoLDbContext db) : base(db)
        {

        }
    }
}
