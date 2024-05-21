using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CharacterBook.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProfessionController : ControllerBase
    {
        private readonly IProfessionManager professionManager;
        public ApiProfessionController(IProfessionManager professionManager)
        {
            this.professionManager = professionManager;
        }

        [HttpGet]
        public IEnumerable<ProfessionDto> Get()
        {
            return professionManager.GetAllData();
        }

    }
}
