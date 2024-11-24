using Azure.Messaging;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using Serilog.Events;
using System.Collections.Generic;
using System.Data;

namespace HeroesOfLegends.Data.Repositories
{
    public class ProfessionRepository : GenericCRUD<Profession>, IProfessionRepository
    {
        public ProfessionRepository(HoLDbContext db,ILogger<DbSet<Profession>> logger) : base(db,logger)
        {
        }

        // Include properties for eager loading of related entities (Cz: včetně vlastností pro okamžité načtení souvisejících entit)
        public IQueryable<Profession> IncludeProperties(IQueryable<Profession> query)
        {
            return query.Include(p => p.ProfessionSkills);
        }

        public override IList<Profession> All()
        {
            dbSet.Include(p => p.ProfessionSkills).Load();
            var data = dbSet.ToList();
            return data;
            
        }

        //------ Synchronous methods --------

        
        /// <exception cref="DataException"></exception>
        public Profession AddProfessionWithSkills(Profession profession,List<int> skillIds)
        {

            ProfessionSkill skill;

            foreach(var id in skillIds)
            {
                skill = db.ProfessionSkill.FirstOrDefault(ps => ps.Id == id);

                if(skill == null)
                {

                    logger.LogError(String.Format("Skill with id {0} not found",id));
                }
                else
                {
                    
                        profession.ProfessionSkills.Add(skill);
                    
                }
            }

            profession = dbSet.Add(profession).Entity;

            try
            {
                db.SaveChanges();
            }
            catch(Exception)
            {
                logger.LogDebug("Error while saving changes");
                throw new DataException("Error while saving changes");
            }
            return profession;
        }

        public void AddSkillToProfession(int professionId,int skillId)
        {
            // Find profession
            var profession = dbSet.Include(p => p.ProfessionSkills).FirstOrDefault(p => p.Id == professionId);
            if(profession == null)
            {
                throw new DataException("Profession not found");
            }

            // Find skill
            var skill = db.ProfessionSkill.FirstOrDefault(ps => ps.Id == skillId);
            if(skill == null)
            {
                throw new DataException("Skill not found");
            }
            // Add skill to profession
            if(!profession.ProfessionSkills.Contains(skill))
            {
                profession.ProfessionSkills.Add(skill);
                db.SaveChanges();
            }
        }
        public void RemoveSkillFromProfession(int professionId,int skillId)
        {
            // Find profession
            var profession = dbSet.Include(p => p.ProfessionSkills).FirstOrDefault(p => p.Id == professionId);
            if(profession == null)
            {
                throw new DataException("Profession not found");
            }

            // Find skill
            var skill = db.ProfessionSkill.FirstOrDefault(ps => ps.Id == skillId);
            if(skill == null)
            {
                throw new DataException("Skill not found");
            }

            // Remove skill from profession
            if(profession.ProfessionSkills.Contains(skill))
            {
                profession.ProfessionSkills.Remove(skill);
                db.SaveChanges();
            }
        }
        public void ChangeBindingProfessionSkillsData(int professionId,IEnumerable<int> skillIds)
        {
            // Find profession
            var profession = dbSet.Include(p => p.ProfessionSkills).FirstOrDefault(p => p.Id == professionId);
            if(profession == null)
            {
                logger.LogError("Profession not found");
            }

            ProfessionSkill skill;

            foreach(var id in skillIds)
            {
                skill = db.ProfessionSkill.FirstOrDefault(ps => ps.Id == id);

                if(skill == null)
                {
                   
                    logger.LogError(String.Format("Skill with id {0} not found",id));
                }
                else 
                {
                    if(profession.ProfessionSkills.Contains(skill))
                    {
                        profession.ProfessionSkills.Remove(skill);
                    }
                    else
                    {
                        profession.ProfessionSkills.Add(skill);
                    }
                }
            }
            try
            {
            db.SaveChanges();
            }
            catch(Exception)
            {
                logger.LogDebug("Error while saving changes");
                throw new DataException("Error while saving changes");
            }
        }

        //------ Asynchronous methods --------

        public async Task AddSkillToProfessionAsync(int professionId,int skillId)
        {
            // Find profession
            var profession = await dbSet.Include(p => p.ProfessionSkills).FirstOrDefaultAsync(p => p.Id == professionId);
            if(profession == null)
            {
                throw new DataException("Profession not found");
            }

            // Find skill
            var skill = await db.ProfessionSkill.FirstOrDefaultAsync(ps => ps.Id == skillId);
            if(skill == null)
            {
                throw new DataException("Skill not found");
            }

            // Add skill to profession
            if(!profession.ProfessionSkills.Contains(skill))
            {
                profession.ProfessionSkills.Add(skill);
                await db.SaveChangesAsync();
            }
        }
        public async Task RemoveSkillFromProfessionAsync(int professionId,int skillId)
        {
            // Find profession
            var profession = await dbSet.Include(p => p.ProfessionSkills).FirstOrDefaultAsync(p => p.Id == professionId);
            if(profession == null)
            {
                throw new DataException("Profession not found");
            }

            // Find skill
            var skill = await db.ProfessionSkill.FirstOrDefaultAsync(ps => ps.Id == skillId);
            if(skill == null)
            {
                throw new DataException("Skill not found");
            }

            // Remove skill from profession
            if(profession.ProfessionSkills.Contains(skill))
            {
                profession.ProfessionSkills.Remove(skill);
                await db.SaveChangesAsync();
            }
        }
        public async Task ChangeBindingProfessionSkillsDataAsync(int professionId,IEnumerable<int> skillIds)
        {
            // Find profession
            var profession = await dbSet.Include(p => p.ProfessionSkills).FirstOrDefaultAsync(p => p.Id == professionId);
            if(profession == null)
            {
                logger.LogError("Profession not found");
                throw new DataException("Profession not found");
            }

            ProfessionSkill skill;

            foreach(var id in skillIds)
            {
                skill = await db.ProfessionSkill.FirstOrDefaultAsync(ps => ps.Id == id);

                if(skill == null)
                {
                    logger.LogError($"Skill with id {id} not found");
                }
                else
                {
                    if(profession.ProfessionSkills.Contains(skill))
                    {
                        profession.ProfessionSkills.Remove(skill);
                    }
                    else
                    {
                        profession.ProfessionSkills.Add(skill);
                    }
                }
            }

            try
            {
                await db.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                logger.LogError(ex,"Error while saving changes");
                throw new DataException("Error while saving changes",ex);
            }
        }




    }
}
