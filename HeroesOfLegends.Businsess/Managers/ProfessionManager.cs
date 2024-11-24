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
        private readonly IProfessionSkillRepository skillRepository;

        public ProfessionManager(HoLDbContext db,ILogger<DbSet<Profession>> logger,IProfessionRepository repository,IMapper mapper) : base(db,logger,mapper)
        {
            this.repository = repository;


        }


        public void ChangeBindingProfessionSkillsData(int professionId,IEnumerable<int> skillInts)
        {
            repository.ChangeBindingProfessionSkillsData(professionId,skillInts);
        }

        public override IList<ProfessionDto> GetAllData()
        {
            IList<Profession> date = All();

            return mapper.Map<IList<ProfessionDto>>(date);
        }

        public override ProfessionDto AddData(ProfessionDto professionDto)
        {
            Profession data = mapper.Map<Profession>(professionDto);
            //Profession addData = Insert(data);
            Profession addData = repository.AddProfessionWithSkills(data,professionDto.SkillIds);
            return mapper.Map<ProfessionDto>(addData);

        }
    }
}
