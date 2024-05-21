using HeroeOfLegends.Businsess.Models;

namespace HeroeOfLegends.Businsess.Interfaces
{
	public interface IProfessionManager
	{
		IList<ProfessionDto> GetAllData();
	}
}