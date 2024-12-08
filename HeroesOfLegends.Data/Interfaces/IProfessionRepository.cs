using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface IProfessionRepository : IGenericCRUD<Profession>
    {
        Profession AddProfessionWithSkills(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills);
        Task<Profession> AddProfessionWithSkillsAsync(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills);
        void AddSkillToProfession(int professionId,int skillId);
        Task AddSkillToProfessionAsync(int professionId,int skillId);
        IList<Profession> All();
        void ChangeBindingProfessionSkillsData(int professionId,IEnumerable<int> skillIds);
        Task ChangeBindingProfessionSkillsDataAsync(int professionId,IEnumerable<int> skillIds);
        void RemoveSkillFromProfession(int professionId,int skillId);
        Task RemoveSkillFromProfessionAsync(int professionId,int skillId);
        public Profession UpdateProfessionWithSkills(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills);
        Task<Profession> UpdateProfessionWithSkillsAsync(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills);
    }
}