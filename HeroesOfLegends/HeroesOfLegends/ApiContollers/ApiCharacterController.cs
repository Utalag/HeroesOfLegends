
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CharacterBook.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCharacterController : ControllerBase
    {
        private ICharacterManager characterManager;

        public ApiCharacterController(ICharacterManager characterManager)
        {
            this.characterManager = characterManager;
        }

        // GET: api/<CharacterController>
        [HttpGet]
        public IEnumerable<CharacterDto> Get()
        {
            return characterManager.GetAllData();
        }

        //[HttpGet]
        //public IEnumerable<ProfessionDto> GetAllProf()
        //{
        //	return characterManager.GetAllProfessions();
        //}

        //// GET api/<CharacterController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //	return "value";
        //}

        //POST api/<CharacterController>
        [HttpPost]
        public void Post([FromBody] CharacterDto value)
        {
            characterManager.AddCharacter(value);
        }

        //// PUT api/<CharacterController>/5
        //[HttpPut("{id}")]
        //public void Put(int id,[FromBody] string value)
        //{
        //}

        //// DELETE api/<CharacterController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
