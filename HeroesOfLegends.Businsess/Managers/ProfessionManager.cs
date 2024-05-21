using AutoMapper;
using HeroeOfLegends.Businsess.Interfaces;
using HeroeOfLegends.Businsess.Models;
using HeroeOfLegends.Data.Interfaces;
using HeroeOfLegends.Models;

namespace HeroeOfLegends.Businsess.Managers
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
