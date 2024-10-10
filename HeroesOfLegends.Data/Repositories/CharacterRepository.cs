using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;
using Microsoft.EntityFrameworkCore;


namespace HeroesOfLegends.Data.Repositories
{
    public class CharacterRepository : GenericCRUD<Character,HoLDbContext>, ICharacterRepository
    {
        private DbSet<Character> character;
        private DbSet<Race> races;

        
        public CharacterRepository(HoLDbContext db) : base(db)
        {
            character = db.Set<Character>();
            races = db.Set<Race>();
        }





        /// <summary>
        /// Přidá novou postavu (zatím jen fyzické atributy)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Character AddCharacter(Character entity)
        {
           
           
            var data = dbSet.Add(entity);
            db.SaveChanges();
            return data.Entity;
        }





    }
}
