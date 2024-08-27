using HeroesOfLegends.Models;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface IRaceRepository : IGenericCRUD<Race>
    {
        IList<Race> FindAllByIds(IEnumerable<int> ids);
        Task<IList<Race>> FindAllByIdsAsnyc(IEnumerable<int> ids);
    }
}