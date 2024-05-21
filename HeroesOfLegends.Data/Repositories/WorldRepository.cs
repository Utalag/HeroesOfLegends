using CharacterBook.Data;
using HeroeOfLegends.Data.Interfaces;
using HeroeOfLegends.Models;

namespace HeroeOfLegends.Data.Repositories
{
    public class WorldRepository : GenericCRUD<World,HoLDbContext>, IWorldRepository
    {
        public WorldRepository(HoLDbContext db) : base(db)
        {

        }
    }
}
