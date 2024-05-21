using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Models
{
	/// <summary>
	/// Vazební tabulka 
	/// </summary>
	public class World
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
		public int Id { get; set; }
		public string WorldName { get; set; } = string.Empty;

		//-------------
		//public int RaceId {  get; set; }
		//public int NarrativeId { get; set; }
		//public virtual Race? Races { get; set; }
		//public virtual Narrative? Narrative { get; set; }
		/// <summary>
		/// Seznam ras
		/// </summary>
		public virtual List<Race>? Races { get; set; } = new List<Race>();
		public virtual List<Narrative>? Narratives { get; set; } = new List<Narrative>();

		//-------------



		/// <summary>
		/// Data do databáze
		/// </summary>
		/// <returns></returns>
		public World[] Initial()
		{
			return new World[]
			{
				new World
				{
					Id = 1,
					WorldName = "Fantasy svět",

				},

				new World
				{
					Id = 2,
					WorldName = "Postapo",
				},
			
				new World
				{
					Id = 3,
					WorldName = "Reálný svět",
				
				}
			};

		}
	}
}
