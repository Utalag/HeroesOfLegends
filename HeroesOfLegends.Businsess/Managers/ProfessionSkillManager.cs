using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using HeroessOfLegends.Businsess.Managers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class ProfessionSkillManager : GenericManager<ProfessionSkill,ProfessionSkillDto>, IProfessionSkillManager
    {
        private readonly IProfessionSkillRepository repository;

        public ProfessionSkillManager(HoLDbContext db,ILogger<DbSet<ProfessionSkill>> logger,IProfessionSkillRepository repository) : base(db,logger)
        {
            this.repository = repository;
        }

        public List<ProfessionSkillDto> GetProfessionSkillByLevel(int level)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetSkillsByLevel(level));
            return skills;
        }
        public List<ProfessionSkillDto> GetProfessionSkillByLevelAsync(int level)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetSkillsByLevelAsync(level));
            return skills;
        }

        public List<ProfessionSkillDto> GetProfessionSkillBySkillClass(SkillClassEnum skillClass)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetSkillClass(skillClass));
            return skills;
        }
        public List<ProfessionSkillDto> GetProfessionSkillBySkillClassAsync(SkillClassEnum skillClass)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetSkillClassAsync(skillClass));
            return skills;
        }

    }
}
