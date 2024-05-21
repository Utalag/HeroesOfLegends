using HeroeOfLegends.Businsess.Models;

namespace HeroeOfLegends.Businsess.Interfaces
{
	public interface INarrativeManager //: INarrativeRepository
	{
		IList<NarrativeDto> GetAll();
		IList<string> GetAllName();
	}
}