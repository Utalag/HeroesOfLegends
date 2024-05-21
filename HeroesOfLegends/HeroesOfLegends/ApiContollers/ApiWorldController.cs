using HeroeOfLegends.Businsess.Interfaces;
using HeroeOfLegends.Businsess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CharacterBook.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiWorldController : ControllerBase
    {
        private readonly IWorldManager wordlManager;

        public ApiWorldController(IWorldManager wordlManager)
        {
            this.wordlManager = wordlManager;
        }

        [HttpGet]
        public IEnumerable<WorldDto> GetWorlds()
        {
            var worlds = wordlManager.GetAllWorld();
            return worlds;
        }



        [HttpPost]
        public IActionResult AddWorld([FromBody] WorldDto world)
        {
            WorldDto worldCreate = wordlManager.AddWorld(world);
            //return Created(worldCreate);
            return StatusCode(StatusCodes.Status201Created, worldCreate);
        }


        //[HttpPut("{id}")]
        //public void Put(int id,[FromBody] string value)
        //{
        //}


        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
