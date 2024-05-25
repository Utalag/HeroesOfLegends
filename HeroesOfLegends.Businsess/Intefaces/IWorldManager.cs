using HeroesOfLegends.Businsess.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IWorldManager
    {
        WorldDto AddWorld(WorldDto worldDto);
        IList<WorldDto> GetAllWorld();

        public IList<WorldDto> GetSelectedWorld(int page = 0,int pageSize = int.MaxValue);


    }
}