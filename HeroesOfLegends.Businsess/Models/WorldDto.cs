using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Businsess.Models
{
	/// <summary>
	/// Vazební tabulka 
	/// </summary>
	public class WorldDto
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
		public int Id { get; set; }
		public string WorldName { get; set; } = string.Empty;

		public virtual IList<string>? NarrativesNames { get; set; } = new List<string>(); // jen seznam jmen příběhů
		public virtual IList<int>? NarrativeIds { get; set; } = new List<int>();
		public virtual List<int>? RaceIds { get; set; } = new List<int>(); 

		//-------------

		//public virtual IList<Race>? Races { get; set; } = new List<Race>();
		//public virtual IList<NarrativeDto>? Narratives { get; set; } = new List<NarrativeDto>();

		//-------------


	}
}
