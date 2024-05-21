namespace HeroesOfLegends.Businsess.Models
{
    public class ExtendWorldDto : WorldDto
    {
        // rozšíření pro zobrazení ras
        public List<RaceDto> RacesAll { get; set; } = new List<RaceDto>();

        // rozšíření pro zobrazení příběhů
        public NarrativeDto NarativeAll { get; set; } = new NarrativeDto();

        // rozšíření pro zobrazení kovů

        // rozšíření pro zobrazení XXXX
    }
}
