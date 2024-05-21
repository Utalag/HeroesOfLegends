using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Models
{
	public class Fight
	{
		public int Id { get; set; }
		public string NameSkill { get; set; } = string.Empty;			// název skillu
		public string DescriptionSkill {  get; set; } = string.Empty;	// popis skillu

	}
}
