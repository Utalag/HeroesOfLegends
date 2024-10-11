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
        IEnumerable<ProfessionSkill> GetSkillClass(SkillClassEnum skill);
        Task<IEnumerable<ProfessionSkill>> GetSkillClassAsync(SkillClassEnum skill);
        IEnumerable<ProfessionSkill> GetSkillsByLevel(int level);
        Task<IEnumerable<ProfessionSkill>> GetSkillsByLevelAsync(int level);
    }
}
