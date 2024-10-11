using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class ProfessionManager : GenericManager<Profession,ProfessionDto>, IProfessionManager
    {
        private readonly IProfessionRepository repository;

        public ProfessionManager(HoLDbContext db,ILogger<DbSet<Profession>> logger,IProfessionRepository repository) : base(db,logger)
        {
            this.repository = repository;
        }
    }
}
