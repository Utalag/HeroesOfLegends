using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace HeroesOfLegends.Businsess.Managers
{
    public class ProfessionSkillManager : GenericManager<ProfessionSkill,ProfessionSkillDto>, IProfessionSkillManager
    {
        private readonly IProfessionSkillRepository repository;

        public ProfessionSkillManager(HoLDbContext db,ILogger<DbSet<ProfessionSkill>> logger,IProfessionSkillRepository repository,IMapper mapper) : base(db,logger,mapper)
        {
            this.repository = repository;
        }
        // ----------------- Filtered dependency data by level  -----------------
        public SpecificSkillDto GetProfessionSkillByLevel(ProfessionSkillDto skill,int level)
        {
            var data = skill.BaseSpecificSkills.Where(x => x.ProfessionClass == skill.ProfessionClass).Where(x => x.Level <= level).LastOrDefault();
            return mapper.Map<SpecificSkillDto>(data);
        }

        // ----------------- SkillClassEnum -----------------
        public List<ProfessionSkillDto> GetAllProfessionSkillBySkillClass(SkillClassEnum skillClass)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetSkillClass(skillClass));
            return skills;
        }
        public List<ProfessionSkillDto> GetAllProfessionSkillBySkillClassAsync(SkillClassEnum skillClass)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetSkillClassAsync(skillClass));
            return skills;
        }
        //----------------- KnowledgeGroupEnum -----------------
        public List<ProfessionSkillDto> GetAllProfessionSkillByKnowledgeGroup(LevelGroupEnum knowledgeGroup)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.KnowledgeGroupAsync(knowledgeGroup));
            return skills;
        }
        public List<ProfessionSkillDto> GetAllProfessionSkillByKnowledgeGroupAsync(LevelGroupEnum knowledgeGroup)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.KnowledgeGroupAsync(knowledgeGroup));
            return skills;
        }
        //----------------- ProfessionClassEnum -----------------
        public List<ProfessionSkillDto> GetAllProfessionSkillByProfessionClass(ProfessionClassEnum professionClass)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.GetProfessionClass(professionClass));
            return skills;
        }
        public List<ProfessionSkillDto> GetAllProfessionSkillByProfessionClassAsync(ProfessionClassEnum professionClass)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(repository.ProfessionClassAsync(professionClass));
            return skills;
        }
        //----------------- GetProfessionSkillWithFilter -----------------

        public async Task<List<ProfessionSkillDto>> GetProfessionSkillWithFilter_Async(LevelGroupEnum knowledgeGroup = LevelGroupEnum.all,SkillClassEnum skillClass=SkillClassEnum.allSkill,ProfessionClassEnum professionClass=ProfessionClassEnum.all,bool skillsWithDependecies = false)
        {
            var skills = mapper.Map<List<ProfessionSkillDto>>(await repository.GetSkillWithFilter_Async(knowledgeGroup,skillClass,professionClass,skillsWithDependecies));
            return skills;
        }
    }
}
