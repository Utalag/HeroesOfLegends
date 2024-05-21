using HeroeOfLegends.Models;

namespace HeroeOfLegends.Data.Interfaces
{
    public interface IRaceRepository : IGenericCRUD<Race>
    {
        IList<Race> FindAllByIds(IEnumerable<int> ids);
    }
}