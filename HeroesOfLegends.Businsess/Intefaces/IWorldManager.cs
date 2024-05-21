using HeroesOfLegends.Businsess.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IWorldManager
    {
        WorldDto AddWorld(WorldDto worldDto);
        IList<WorldDto> GetAllWorld();


    }
}