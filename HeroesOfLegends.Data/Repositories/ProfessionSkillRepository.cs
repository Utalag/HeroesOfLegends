using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Data.Repositories
{
    public class ProfessionSkillRepository : GenericCRUD<ProfessionSkill>, IProfessionSkillRepository
    {
        public ProfessionSkillRepository(HoLDbContext db,ILogger<DbSet<ProfessionSkill>> logger) : base(db,logger)
        {
        }

        /// <summary>
        /// The attribute to filter entry by
        /// </summary>
        /// <param name="skillClass">SkillClassEnum</param>
        /// <example>
        /// <code>
        /// var skillClass = await GetSkillClassAsync(SkillClassEnum.combatSkill);
        /// </code>
        /// </example>
        /// <returns>The task result contains the list of filtered records.</returns>
        public IEnumerable<ProfessionSkill> GetSkillClass(SkillClassEnum skillClass)
        {
            try
            {
                var skills = db.ProfessionSkill.Where(s => s.SkillClass == skillClass).ToList();
                if(!skills.Any())
                {
                    logger.LogWarning("Skills not found");
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for profession {Profession}",skillClass);
                return new List<ProfessionSkill>();
            }
        }

        public IEnumerable<ProfessionSkill> GetProfessionClass(ProfessionClassEnum professionClass)
        {
            try
            {
                var skills = db.ProfessionSkill.Where(s => s.ProfessionClass == professionClass).ToList();
                if(!skills.Any())
                {
                    logger.LogWarning("Skills not found");
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for profession {Profession}",professionClass);
                return new List<ProfessionSkill>();
            }
        }

        public IEnumerable<ProfessionSkill> GetSkillWithIds(List<int> ids)
        {
            IList<ProfessionSkill> skills= new List<ProfessionSkill>();
            foreach(int id in ids)
            {
                var skill = dbSet.FirstOrDefault(i=>i.Id==id);
                
                if(skill == null )
                {
                    logger.LogWarning(String.Format("GetSkillWithIds: id {0} not found!"));
                }
                else
                {
                    skills.Add(skill);
                }
            }
            return skills;
        }
        // -----------------  -----------------

        // -----------------  -----------------

        /// <summary>
        /// The attribute to filter entry by
        /// </summary>
        /// <param name="skillClass">SkillClassEnum</param>
        /// <example>
        /// <code>
        /// var skillClass = await GetSkillClassAsync(SkillClassEnum.combatSkill);
        /// </code>
        /// </example>
        /// <returns>The task result contains the list of filtered records.</returns>
        public async Task<IEnumerable<ProfessionSkill>> GetSkillClassAsync(SkillClassEnum skillClass)
        {
            try
            {
                var skills = await db.ProfessionSkill.Where(s => s.SkillClass == skillClass).ToListAsync();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("Skills not found for skill class {SkillClass}",skillClass);
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for skill class {SkillClass}",skillClass);
                return new List<ProfessionSkill>();
            }
        }

        /// <summary>
        /// The attribute to filter entry by
        /// </summary>
        /// <param name="knowledgeGroup">KnowledgeGroupEnum</param>
        /// <example>
        /// <code>
        /// var knowledgeGroup = await KnowledgeGroupAsync(KnowledgeGroupEnum.novice);
        /// </code>
        /// </example>
        /// <returns>The task result contains the list of filtered records.</returns>
        public async Task<IEnumerable<ProfessionSkill>> KnowledgeGroupAsync(LevelGroupEnum knowledgeGroup)
        {
            try
            {
                var skills = await db.ProfessionSkill.Where(s => s.KnowledgeGroup == knowledgeGroup).ToListAsync();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("Skills not found for skill class {KnowledgeGroup}",knowledgeGroup);
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for skill class {KnowledgeGroup}",knowledgeGroup);
                return new List<ProfessionSkill>();
            }
        }

        /// <summary>
        /// The attribute to filter entry by
        /// </summary>
        /// <param name="professionClass">ProfessionClassEnum</param>
        /// <example>
        /// <code>
        /// var skills = await ProfessionClassAsync(ProfessionClassEnum.N_warrior);
        /// </code>
        /// </example>
        /// <returns>The task result contains the list of filtered records.</returns>
        public async Task<IEnumerable<ProfessionSkill>> ProfessionClassAsync(ProfessionClassEnum professionClass)
        {
            try
            {
                var skills = await db.ProfessionSkill.Where(s => s.ProfessionClass == professionClass).ToListAsync();
                if(skills == null || !skills.Any())
                {
                    logger.LogWarning("Skills not found for skill class {ProfessionClass}",professionClass);
                    return new List<ProfessionSkill>();
                }
                return skills;
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"An error occurred while getting skills for skill class {ProfessionClass}",professionClass);
                return new List<ProfessionSkill>();
            }
        }


        // -----------------  -----------------

        public async Task<IEnumerable<ProfessionSkill>> GetSkillWithFilter_Async(LevelGroupEnum knowledgeGroup,SkillClassEnum skillClass,ProfessionClassEnum professionClass,bool skillsWithDependecies)
        {
            var skillQuery = db.ProfessionSkill.AsQueryable();
            skillQuery = skillQuery.Where(s => s.KnowledgeGroup == knowledgeGroup && s.SkillClass == skillClass && s.ProfessionClass == professionClass);


            if(skillsWithDependecies)
            {
                skillQuery = skillQuery.Where(s => s.DependencySkillId == 0);
            }
            return await skillQuery.ToListAsync();

        }




    }
}
