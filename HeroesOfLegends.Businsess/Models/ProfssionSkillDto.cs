using HeroesOfLegends.Data.Models;
namespace HeroesOfLegends.Businsess.Models
{
    public class ProfessionSkillDto
    {
        public int SkillId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public SkillClassEnum SkillClass { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CreateByUserName { get; set; } = string.Empty; // (Cz: vytvořil uživatel ???)
    }
}
