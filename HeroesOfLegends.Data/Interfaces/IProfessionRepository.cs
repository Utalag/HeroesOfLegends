using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Data.Interfaces
{
    public interface IProfessionRepository : IGenericCRUD<Profession>
    {
        Profession AddProfessionWithSkills(Profession profession,List<int> skillIds);
        void AddSkillToProfession(int professionId,int skillId);
        Task AddSkillToProfessionAsync(int professionId,int skillId);
        void ChangeBindingProfessionSkillsData(int professionId,IEnumerable<int> skillIds);
        Task ChangeBindingProfessionSkillsDataAsync(int professionId,IEnumerable<int> skillIds);
        void RemoveSkillFromProfession(int professionId,int skillId);
        Task RemoveSkillFromProfessionAsync(int professionId,int skillId);
    }
}