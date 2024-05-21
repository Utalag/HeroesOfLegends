using HeroesOfLegends.Businsess.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IRaceManager
    {
        //---CRUD---//
        RaceDto AddRace(RaceDto raceDto);
        RaceDto? DeleteRace(int raceDto);
        RaceDto? UpdateRace(RaceDto raceDto,int raceId);
        RaceDto? GetRace(int id);

        //--- vypisování entit --- //
        /// <summary>
        /// Vrátí včechny monstra v listu
        /// </summary>
        /// <returns>IList</returns>
        IList<RaceDto> GetAllRace();
        IList<RaceDto> GetAllRace(int page = 0,int pageSize = int.MaxValue);


    }
}
