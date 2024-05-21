using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Businsess.Managers
{
    public class ProfessionManager : IProfessionManager
	{
		private readonly IProfessionRepository repository;
		private readonly IMapper mapper;

		public ProfessionManager(IProfessionRepository repository,IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public IList<ProfessionDto> GetAllData()
		{
			IList<Profession> data = repository.All();
			return mapper.Map<IList<ProfessionDto>>(data);
		}
	}
}
