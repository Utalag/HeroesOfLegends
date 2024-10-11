using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface INarrativeRepository : IGenericCRUD<Narrative>
    {
        IList<Narrative> FindAllByNames(IEnumerable<string> names);
    }
}