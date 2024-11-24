using HeroesOfLegends.Data.Models.SkillsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface ISpecificSkillReposotory : IGenericCRUD<BaseSpecificSkill>
    {
        //BaseSpecificSkill GetSpecificSkillByLevel(int level);
        //Task<BaseSpecificSkill> GetSpecificSkillByLevelAsync(int level);

    }
}
