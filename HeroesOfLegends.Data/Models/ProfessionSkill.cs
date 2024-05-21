namespace HeroeOfLegends.Models
{
    internal class ProfessionSkill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;            // název dovednosti
        public string Description { get; set; } = string.Empty;     // popis dovednosti
        public int Level { get; set; }                              // úroveň od které je schopnost dostupná
        public int ProfessionPointex { get; set; }                  // počet profibodů za dovednost











    }
}
