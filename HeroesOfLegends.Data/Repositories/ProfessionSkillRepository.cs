using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using Microsoft.EntityFrameworkCore;
using HeroesOfLegends.Database;

using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Data.Repositories
{
    public class ProfessionSkillRepository : GenericCRUD<ProfessionSkill>, IProfessionSkillRepository
    {
        public ProfessionSkillRepository(HoLDbContext db,ILogger<DbSet<ProfessionSkill>> logger) : base(db,logger)
        {
        }

        public IEnumerable<ProfessionSkill> GetSkillsByLevel(int level)
        {
            try
            {
                var skills = db.Skills.Where(s => s.Level == level).ToList();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("No skills found for level {Level}",level);
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for level {Level}",level);
                return new List<ProfessionSkill>();
            }
        }

        public async Task<IEnumerable<ProfessionSkill>> GetSkillsByLevelAsync(int level)
        {
            try
            {
                var skills = await db.Skills.Where(s => s.Level == level).ToListAsync();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("No skills found for level {Level}",level);
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for level {Level}",level);
                return new List<ProfessionSkill>();
            }

        }

        public IEnumerable<ProfessionSkill> GetSkillClass(SkillClassEnum skill)
        {
            try
            {
                var skills = db.Skills.Where(s => s.SkillClass == skill).ToList();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("Skills not found");
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for profession {Profession}",skill);
                return new List<ProfessionSkill>();
            }
        }

        public async Task<IEnumerable<ProfessionSkill>> GetSkillClassAsync(SkillClassEnum skill)
        {
            try
            {
                var skills = await db.Skills.Where(s => s.SkillClass == skill).ToListAsync();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("Skills not found for skill class {SkillClass}",skill);
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for skill class {SkillClass}",skill);
                return new List<ProfessionSkill>();
            }
        }
    }
}
