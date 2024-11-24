using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Data.Models
{

	public class World
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string WorldName { get; set; } = string.Empty;
		public string WorldDescription { get; set; } = string.Empty;
		[Range(0, 100)]
		public int AmountOfMagicInTheWorld { get; set; } 
	


        public virtual List<Race>? Races { get; set; } = new List<Race>();
		public virtual List<Narrative>? Narratives { get; set; } = new();







		public List<World> Initial()
		{
			
			return new World[]
			{
				new World
				{
					Id = 1,
					WorldName = "Fantasy svět",
					AmountOfMagicInTheWorld = 100,

				},

				new World
				{
					Id=2,
					WorldName = "Postapo",
					AmountOfMagicInTheWorld = 25,
				},

				new World
				{
					Id=3,
					WorldName = "Reálný svět",
					AmountOfMagicInTheWorld = 0,

				}
			}.ToList();

		}
	}
}
