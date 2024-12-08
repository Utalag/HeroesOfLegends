using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HeroesOfLegends.Businsess.Managers
{
    public class ProfessionManager : GenericManager<Profession,ProfessionDto>, IProfessionManager
    {
        private readonly IProfessionRepository repository;

        public ProfessionManager(HoLDbContext db,ILogger<DbSet<Profession>> logger,IProfessionRepository repository,IMapper mapper) : base(db,logger,mapper)
        {
            this.repository = repository;
        }

        public override IList<ProfessionDto> GetAllData()
        {
            IList<Profession> date = repository.All();
            return mapper.Map<IList<ProfessionDto>>(date);
        }

        public void ChangeBindingProfessionSkillsData(int professionId,IEnumerable<int> skillInts)
        {
            repository.ChangeBindingProfessionSkillsData(professionId,skillInts);
        }

        public override ProfessionDto? UpdateData(ProfessionDto professionDto,int id)
        {
            if(!ExistsWithId(id))
                return null;
            Profession data = mapper.Map<Profession>(professionDto);
            Profession updateData = repository.UpdateProfessionWithSkills(data,professionDto.BeginnerSkillIds,professionDto.AdvancedSkillIds,professionDto.ExpertSkillIds);
            return mapper.Map<ProfessionDto>(updateData);
        }

        public override ProfessionDto AddData(ProfessionDto professionDto)
        {
            Profession data = mapper.Map<Profession>(professionDto);
            Profession addData = repository.AddProfessionWithSkills(data,professionDto.BeginnerSkillIds,professionDto.AdvancedSkillIds,professionDto.ExpertSkillIds);
            return mapper.Map<ProfessionDto>(addData);

        }

        //-------------------------------- ASYNC METHODS --------------------------------
        public async Task ChangeBindingProfessionSkillsDataAsync(int professionId,IEnumerable<int> skillInts)
        {
            await repository.ChangeBindingProfessionSkillsDataAsync(professionId,skillInts);
        }

        public override async Task<ProfessionDto?> UpdateDataAsync(ProfessionDto professionDto,int id)
        {
            if(!ExistsWithId(id))
                return null;
            Profession data = mapper.Map<Profession>(professionDto);
            Profession updateData = await repository.UpdateProfessionWithSkillsAsync(data,professionDto.BeginnerSkillIds,professionDto.AdvancedSkillIds,professionDto.ExpertSkillIds);
            return mapper.Map<ProfessionDto>(updateData);
        }

        public override async Task<ProfessionDto> AddDataAsync(ProfessionDto professionDto)
        {
            Profession data = mapper.Map<Profession>(professionDto);
            Profession addData = await repository.AddProfessionWithSkillsAsync(data,professionDto.BeginnerSkillIds,professionDto.AdvancedSkillIds,professionDto.ExpertSkillIds);
            return mapper.Map<ProfessionDto>(addData);

        }

    }
}
