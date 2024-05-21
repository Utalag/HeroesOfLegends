using HeroesOfLegends.Models;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface INarrativeRepository : IGenericCRUD<Narrative>
    {
        IList<Narrative> FindAllByNames(IEnumerable<string> names);
    }
}