using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class RaceManager : GenericManager<Race,RaceDto>, IRaceManager
    {
        private readonly IRaceRepository repository;

        public RaceManager(HoLDbContext db,ILogger<DbSet<Race>> logger,IRaceRepository repository,IMapper mapper) : base(db,logger,mapper)
        {
            this.repository = repository;
        }
    };
}
