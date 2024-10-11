using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IProfessionSkillManager : IGenericManager<ProfessionSkillDto>
    {
        List<ProfessionSkillDto> GetProfessionSkillByLevel(int level);
        List<ProfessionSkillDto> GetProfessionSkillByLevelAsync(int level);
        List<ProfessionSkillDto> GetProfessionSkillBySkillClass(SkillClassEnum skillClass);
        List<ProfessionSkillDto> GetProfessionSkillBySkillClassAsync(SkillClassEnum skillClass);
    }
}
