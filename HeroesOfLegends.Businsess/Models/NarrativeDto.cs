using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Businsess.Models
{
    public class NarrativeDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id { get; set; }
        public string NarrativeName { get; set; } = string.Empty;
        public string NarrativeDescription { get; set; } = string.Empty;
        public string Era { get; set; } = string.Empty;
        public int Year { get; set; }

        public int WorldId { get; set; }

        public List<int> RaceIds { get; set; } = new List<int>();


    }


}
