using HeroesOfLegends.Businsess.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
	public interface IProfessionManager
	{
		IList<ProfessionDto> GetAllData();
	}
}