using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterBook.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiNarrativeController : ControllerBase
    {
        private readonly INarrativeManager naraviveManager;

        public ApiNarrativeController(INarrativeManager naraviveManager)
        {
            this.naraviveManager = naraviveManager;
        }


        //[HttpGet]
        //public IActionResult Names()
        //{
        //    var names = naraviveManager.GetAllName();
        //    return Ok(names);
        //}

  //      [HttpGet]
  //      public IActionResult GetAllData()
  //      {
  //          var narratives = naraviveManager.GetAll();
		//	return Ok(narratives);
		//}


        [HttpGet]
        public ICollection<NarrativeDto> GetAll()
        {
            return naraviveManager.GetAll();
        }
    }
}
