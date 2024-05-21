using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;
using Microsoft.EntityFrameworkCore;


namespace HeroesOfLegends.Data.Repositories
{
    public class CharacterRepository : GenericCRUD<Character,HoLDbContext>, ICharacterRepository
    {
        private DbSet<Profession> professions;
        private DbSet<Race> races;
        public CharacterRepository(HoLDbContext db) : base(db)
        {
            professions = db.Set<Profession>();
            races = db.Set<Race>();
        }




        /// <summary>
        /// Přidá novou postavu (zatím jen fyzické atributy)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Character AddCharacter(Character entity)
        {
            var race = races.Find(entity.RaceId);
            try
            {
                //race se nesmí rovnat null protože by to znamenalo že se nepodařilo najít rasu
                entity.Strength = entity.St_bool ? 9 + entity.St_Primar + entity.St_DiceRoll + race.Strength_Corection : entity.St_DiceRoll - 1 + race.Strength;
                entity.Agility = entity.Ag_bool ? 9 + entity.Ag_Primar + entity.Ag_DiceRoll + race.Agility_Corection : entity.Ag_DiceRoll - 1 + race.Agility;
                entity.Constitution = entity.Con_bool ? 9 + entity.Co_Primar + entity.Co_DiceRoll + race.Constitution_Corection : entity.Co_DiceRoll - 1 + race.Constitution;
                entity.Intelligence = entity.Int_bool ? 9 + entity.In_Primar + entity.In_DiceRoll + race.Intelligence_Correction : entity.In_DiceRoll - 1 + race.Intelligence;
                entity.Charisma = entity.Cha_bool ? 9 + entity.Cha_Primar + entity.Cha_DiceRoll + race.Charisma_Correction : entity.Cha_DiceRoll - 1 + race.Charisma;

            }
            catch(Exception e)
            {
                e.Source = "Chyba při výpočtu atributů ( CharacterRepository.AddCharacter";
                Console.WriteLine(e);
                throw;
            }


            var data = dbSet.Add(entity);
            db.SaveChanges();
            return data.Entity;
        }





    }
}
