using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;
using HeroessOfLegends.Businsess.Managers;

namespace HeroesOfLegends.Businsess.Managers
{
    public class RaceManager :GenericManager<Race,RaceDto> ,IRaceManager
    {
        private readonly IRaceRepository raceRepository;
        private readonly IMapper mapper;

        public RaceManager(HoLDbContext db,IMapper mapper) : base(db,mapper)
        {
        }
    };
}
