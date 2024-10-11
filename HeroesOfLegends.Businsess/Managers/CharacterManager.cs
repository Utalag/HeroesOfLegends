using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using HeroessOfLegends.Businsess.Managers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class CharacterManager : GenericManager<Character,CharacterDto>, ICharacterManager
    {
        private readonly IRaceRepository repository;

        public CharacterManager(HoLDbContext db,ILogger<DbSet<Character>> logger,IRaceRepository repository) : base(db,logger)
        {
            this.repository = repository;
        }

    };

}
