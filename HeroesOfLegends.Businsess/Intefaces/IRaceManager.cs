using HeroesOfLegends.Businsess.Models;
using HeroessOfLegends.Businsess.Intefaces;

namespace HeroesOfLegends.Businsess.Interfaces
{
    public interface IRaceManager : IGenericManager<RaceDto>
    {
        ////---CRUD---//
        //RaceDto AddRace(RaceDto raceDto);
        //RaceDto? DeleteRace(int raceDto);
        //RaceDto? UpdateRace(RaceDto raceDto,int raceId);
        //RaceDto? GetRace(int id);
        //IList<RaceDto> GetAllRace();
        //IList<RaceDto> GetAllRace(int page = 0,int pageSize = int.MaxValue);



        ////---ASYNC CRUD---//

        //Task<RaceDto?> GetRaceAsync(int id);
        //Task<RaceDto> AddRaceAsync(RaceDto raceDto);
        //Task<RaceDto?> UpdateRaceAsync(RaceDto raceDto,int raceId);
        //Task<RaceDto?> DeleteRaceAsync(int raceId);
        //Task<IList<RaceDto>> GetAllRaceAsync();
        //Task<IList<RaceDto>> GetAllRaceAsync(int page = 0,int pageSize = int.MaxValue);
    }
}
