using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Models.SkillsModels;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class SpecificSkillManager : GenericManager<BaseSpecificSkill,SpecificSkillDto>, ISpecificSkillManager
    {

        public SpecificSkillManager(HoLDbContext db,ILogger<DbSet<BaseSpecificSkill>> logger,IMapper mapper) : base(db,logger,mapper)
        {
        }


    }
}
