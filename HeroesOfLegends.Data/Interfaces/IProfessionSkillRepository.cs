using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface IProfessionSkillRepository : IGenericCRUD<ProfessionSkill>
    {
        
        IEnumerable<ProfessionSkill> GetSkillClass(SkillClassEnum skillClass);




        // ----------------- Async -----------------
        Task<IEnumerable<ProfessionSkill>> GetSkillClassAsync(SkillClassEnum skillClass);
        Task<IEnumerable<ProfessionSkill>> KnowledgeGroupAsync(LevelGroupEnum knowledgeGroup);
        Task<IEnumerable<ProfessionSkill>> ProfessionClassAsync(ProfessionClassEnum professionClass);









        Task<IEnumerable<ProfessionSkill>> GetSkillWithFilter_Async(LevelGroupEnum knowledgeGroup,SkillClassEnum skillClass,ProfessionClassEnum professionClass,bool skillsWithDependecies);
        IEnumerable<ProfessionSkill> GetProfessionClass(ProfessionClassEnum professionClass);
        IEnumerable<ProfessionSkill> GetSkillWithIds(List<int> ids);
    }
}
