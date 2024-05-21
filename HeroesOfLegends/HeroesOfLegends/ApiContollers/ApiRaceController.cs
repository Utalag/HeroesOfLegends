using HeroeOfLegends.Businsess.Interfaces;
using HeroeOfLegends.Businsess.Models;
using Microsoft.AspNetCore.Mvc;


namespace CharacterBook.Controllers.Api
{
    [Route("api")]
    [ApiController]
    public class ApiRaceController : ControllerBase
    {
        private readonly IRaceManager raceManagger;

        /// <summary>
        /// konstruktor 
        /// </summary>
        /// <param name="raceManager"></param>
        public ApiRaceController(IRaceManager raceManager)
        {
            raceManagger = raceManager;
        }

        /// <summary>
        /// vypíše všechyny položky na jednu stránku
        /// </summary>
        /// <returns></returns>
        [HttpGet("races")]
        public IEnumerable<RaceDto> GetRaces()
        {
            return raceManagger.GetAllRace();
        }

        /// <summary>
        /// vypsání entit podle zadaného počtu stránek a počtu položek v na stránce
        /// </summary>
        /// <param name="page"> číslo stránky</param>
        /// <param name="pageSize">počet záznamů na stránce</param>
        /// <returns></returns>
        [HttpGet("racesPage")]
        public IEnumerable<RaceDto> GetRace(int page = 0, int pageSize = int.MaxValue)
        {
            return raceManagger.GetAllRace(page, pageSize);
        }

        /// <summary>
        /// vypíše položku se zadaným id
        /// </summary>
        /// <param name="raceId"></param>
        /// <returns></returns>
        [HttpGet("race/{raceId}")]
        public IActionResult GetRace(int raceId)
        {
            RaceDto? raceDto = raceManagger.GetRace(raceId);
            if (raceDto is null)
                return NotFound();

            return Ok(raceDto);
        }

        /// <summary>
        /// Přidání nové rasy
        /// </summary>
        /// <param name="raceDto">raceDto entita</param>
        /// <returns></returns>
        [HttpPost("race")]
        public IActionResult AddRace([FromBody] RaceDto raceDto)  // [FromBody] =Mapování jsme umožnili použitím atributu [FromBody]
        {
            RaceDto? createdRace = raceManagger.AddRace(raceDto);
            return CreatedAtAction(nameof(GetRace), new { raceId = createdRace.RaceId }, createdRace);
            //return Ok(createdRace); // taky funkční

            /*
				Přidanou osobnost nakonec zasíláme klientovi zpět spolu se stavovým
				kódem 201. Pomáháme si zde metodou
				CreatedAtAction(), kde je přidaná osobnost jejím posledním
				parametrem. Ta nám k odpovědi navíc připojí hlavičku s adresou koncového
				bodu pro získání dané osobnosti. Tuto adresu vygeneruje na základě
				předaného názvu odpovídající akce a parametrů pro tuto akci. U nás je to
				parametr monsterId, který předáváme v rámci anonymního objektu.
			 */
        }

        /// <summary>
        /// Editace vybrané rasy
        /// </summary>
        /// <param name="raceDto">RaceDto entita</param>
        /// <param name="raceId">id rasy</param>
        /// <returns></returns>
        [HttpPut("race/{raceId}")]
        public IActionResult EditMonster([FromBody] RaceDto raceDto, int raceId)
        {
            RaceDto? editRace = raceManagger.UpdateRace(raceDto, raceId);
            if (editRace is null)
                return NotFound();
            return Ok(editRace);

        }

        /// <summary>
        /// Smazání rasy
        /// </summary>
        /// <param name="raceId">id rasy</param>
        /// <returns></returns>
        [HttpDelete("race/{raceId}")]
        public IActionResult DeleteRace(int raceId)
        {
            RaceDto? deleteRace = raceManagger.DeleteRace(raceId);
            if (deleteRace is null)
                return NotFound();
            return Ok(deleteRace);
        }
    }
}
