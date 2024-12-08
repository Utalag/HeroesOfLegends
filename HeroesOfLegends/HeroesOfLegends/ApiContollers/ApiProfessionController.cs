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

        [HttpPost("NewProfession")]
        public IActionResult InsertProfesion([FromBody] ProfessionDto profession)
        {
            ProfessionDto professionDto = professionManager.AddData(profession);
            return StatusCode(StatusCodes.Status201Created,professionDto);
        }

        [HttpPut("UpdateProfession")]
        public IActionResult UpdateProfession([FromBody] ProfessionDto profession)
        {
            ProfessionDto professionDto = professionManager.UpdateData(profession,profession.Id);
            return StatusCode(StatusCodes.Status202Accepted,professionDto);
        }


        [HttpDelete("DeleteProfession/{id}")]
        public IActionResult DeleteProfession(int id)
        {
            professionManager.DeleteDate(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }
        
    }
}
