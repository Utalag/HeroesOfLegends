using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models.SkillsModels;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Data.Repositories
{
    public class SpecificSkillReposotory : GenericCRUD<BaseSpecificSkill>, ISpecificSkillReposotory
    {
        public SpecificSkillReposotory(HoLDbContext db,ILogger<DbSet<BaseSpecificSkill>> logger) : base(db,logger)
        {
        }

        //public BaseSpecificSkill GetSpecificSkillByLevel(int level)
        //{

        //    return db.SpecificSkill.Where(x => x.Level == level).FirstOrDefault();

        //}

        //public async Task<BaseSpecificSkill> GetSpecificSkillByLevelAsync(int level)
        //{

        //    return await db.SpecificSkill.Where(x => x.Level == level).FirstOrDefaultAsync();

        //}
    }
}
