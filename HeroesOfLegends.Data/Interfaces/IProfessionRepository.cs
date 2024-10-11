using HeroesOfLegends.Data.Models;
namespace HeroesOfLegends.Data.Interfaces
{
    public interface IProfessionRepository : IGenericCRUD<Profession>
    {
        IList<Profession> FindAllByIds(IEnumerable<int> ids);
        Task<IList<Profession>> FindAllByIdsAsync(IEnumerable<int> ids);
    }
}