using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IProfessionSkillManager : IGenericManager<ProfessionSkillDto>
    {
        List<ProfessionSkillDto> GetAllProfessionSkillByKnowledgeGroup(LevelGroupEnum knowledgeGroup);
        List<ProfessionSkillDto> GetAllProfessionSkillByKnowledgeGroupAsync(LevelGroupEnum knowledgeGroup);
        List<ProfessionSkillDto> GetAllProfessionSkillByProfessionClass(ProfessionClassEnum professionClass);
        List<ProfessionSkillDto> GetAllProfessionSkillByProfessionClassAsync(ProfessionClassEnum professionClass);
        List<ProfessionSkillDto> GetAllProfessionSkillBySkillClass(SkillClassEnum skillClass);
        List<ProfessionSkillDto> GetAllProfessionSkillBySkillClassAsync(SkillClassEnum skillClass);
        SpecificSkillDto GetProfessionSkillByLevel(ProfessionSkillDto skill,int level);
        Task<List<ProfessionSkillDto>> GetProfessionSkillWithFilter_Async(LevelGroupEnum knowledgeGroup = LevelGroupEnum.advacedPlus,SkillClassEnum skillClass = SkillClassEnum.allSkill,ProfessionClassEnum professionClass = ProfessionClassEnum.allSubclasse,bool skillsWithDependecies = false);
    }
}
