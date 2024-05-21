using HeroesOfLegends.Businsess.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
	public interface INarrativeManager //: INarrativeRepository
	{
		IList<NarrativeDto> GetAll();
		IList<string> GetAllName();
	}
}