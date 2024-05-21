using HeroeOfLegends.Businsess.Models;

namespace HeroeOfLegends.Businsess.Interfaces
{
    public interface IWorldManager
    {
        WorldDto AddWorld(WorldDto worldDto);
        IList<WorldDto> GetAllWorld();


    }
}