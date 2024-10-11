using HeroesOfLegends.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using HeroesOfLegends.Data.Models;
using Microsoft.Extensions.Logging;
using HeroesOfLegends.Database;


namespace HeroesOfLegends.Data.Repositories
{
    public class CharacterRepository : GenericCRUD<Character>, ICharacterRepository
    {
        public CharacterRepository(HoLDbContext db,ILogger<DbSet<Character>> logger) : base(db,logger)
        {
        }
    }
}
