using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;

namespace HeroesOfLegends.Data.Database
{
    public static class DbInitializer
    {


        public static async Task InitializeAsync(HoLDbContext context,
            IProfessionRepository professionRepository,
            ICharacterRepository characterRepository,
            IProfessionSkillRepository professionSkillRepository,
            ISpecificSkillReposotory specificSkillReposotory,
            IRaceRepository raceRepository,
            INarrativeRepository narrativeRepository,
            IWorldRepository worldRepository)
        {
            try
            {
                if(!context.Professions.Any())
                {
                    await context.Professions.AddRangeAsync(new Profession().ProfessionInit());
                }
                if(!context.Worlds.Any())
                {
                    await context.Worlds.AddRangeAsync(new World().Initial());
                }
                if(!context.Races.Any())
                {
                    await context.Races.AddRangeAsync(new Race().Initial());
                }
                if (!context.Naratives.Any())
                {
                    await context.Naratives.AddRangeAsync(new Narrative().Initial());
                }
                if(!context.ProfessionSkill.Any())
                {
                    await context.ProfessionSkill.AddRangeAsync(new ProfessionSkill().Initial(1));
                }
                if(!context.Characters.Any())
                {
                    await context.Characters.AddRangeAsync(new Character().Initial());
                }
                // ------- SKILLS -------
         


                context.SaveChangesAsync();
            }
            catch(Exception)
            {

                throw;
            }
        }
    }
}
