using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using HeroesOfLegends.Database;

namespace HeroesOfLegends.Data.Repositories
{
    public class WorldRepository : GenericCRUD<World>, IWorldRepository
    {
        public WorldRepository(HoLDbContext db,ILogger<DbSet<World>> logger) : base(db,logger)
        {
        }
    }
}
