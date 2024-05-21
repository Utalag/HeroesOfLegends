using HeroeOfLegends.Models;

namespace HeroeOfLegends.Data.Interfaces
{
    public interface INarrativeRepository : IGenericCRUD<Narrative>
    {
        IList<Narrative> FindAllByNames(IEnumerable<string> names);
    }
}