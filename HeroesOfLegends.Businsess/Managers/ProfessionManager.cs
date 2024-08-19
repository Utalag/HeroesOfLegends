using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Managers;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;
using HeroessOfLegends.Businsess.Managers;

namespace HeroesOfLegends.Businsess.Managers
{
    public class ProfessionManager : GenericManager<Profession,ProfessionDto> , IProfessionManager
	{
		private readonly IProfessionRepository repository;
		private readonly IMapper mapper;

        public ProfessionManager(HoLDbContext db,IMapper mapper) : base(db,mapper)
        {
        }
    }
}
