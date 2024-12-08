using AutoMapper;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Data;

namespace HeroesOfLegends.Data.Repositories
{
    public class ProfessionRepository : GenericCRUD<Profession>, IProfessionRepository
    {
        private readonly IMapper _mapper;
        public ProfessionRepository(HoLDbContext db,ILogger<DbSet<Profession>> logger,IMapper _mapper) : base(db,logger)
        {
            this._mapper = _mapper;
        }



        //------ Synchronous methods --------
        public override IList<Profession> All()
        {
            var data = dbSet;
                data.Include(p => p.ExpertSkills);
            //data.Include(p => p.BeginnerSkills);
            //data.Include(p => p.AdvancedSkills);
            //data.Include(p => p.ExpertSkills);
            data.ToList();
            
            return data.ToList();
        }


        public Profession AddProfessionWithSkills(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills)
        {

            foreach(var id in beginnerSkills)
            {
                var skill = CheckSkill(id);
                profession.BeginnerSkills.Add(skill);
            }

            foreach(var id in advancedSkills)
            {
                var skill = CheckSkill(id);
                profession.AdvancedSkills.Add(skill);
            }

            foreach(var id in expertSkills)
            {
                var skill = CheckSkill(id);
                profession.ExpertSkills.Add(skill);
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

        public Profession UpdateProfessionWithSkills(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills)
        {

            var oldProfession = dbSet
                .Include(p => p.ExpertSkills)
                .Include(p => p.AdvancedSkills)
                .Include(p => p.BeginnerSkills)
                .FirstOrDefault(p => p.Id == profession.Id);

            if(oldProfession == null)
            {
                throw new DataException("Profession not found");
            }

            ChangeSkills(oldProfession.BeginnerSkills,beginnerSkills);
            ChangeSkills(oldProfession.AdvancedSkills,advancedSkills);
            ChangeSkills(oldProfession.ExpertSkills,expertSkills);
            /*
            //List<int> oldSkills = oldProfession.ExpertSkills.Select(i=>i.Id).ToList();
            
            //List<int> addSkillsId = oldSkills.Except(beginnerSkills).ToList();
            //List<int> removeSkillsId = beginnerSkills.Except(oldSkills).ToList();
            
            //foreach(var id in addSkillsId)
            //{
            //    var skill = CheckSkill(id);
            //    if(skill != null)
            //    {
            //        oldProfession.ExpertSkills.Add(skill);
            //    }
            //}

            //foreach(var id in removeSkillsId)
            //{
            //    var skill = CheckSkill(id);
            //    if(skill != null)
            //    {
            //        oldProfession.ExpertSkills.Remove(skill);
            //    }
            //}
             */
            
            oldProfession.Name = profession.Name;
            oldProfession.Description = profession.Description;
            oldProfession.Level = profession.Level;
            oldProfession.HpRangeMin = profession.HpRangeMin;
            oldProfession.HpRangeMax = profession.HpRangeMax;
            oldProfession.WizardMana = profession.WizardMana;
            oldProfession.HasWizardMana = profession.HasWizardMana;
            oldProfession.RengerMana = profession.RengerMana;
            oldProfession.HasRengerMana = profession.HasRengerMana;
            oldProfession.AlchemiMana = profession.AlchemiMana;
            oldProfession.HasAlchemiMana = profession.HasAlchemiMana;
            oldProfession.SpecialdMana = profession.SpecialdMana;
            oldProfession.HasSpecialdMana = profession.HasSpecialdMana;

            profession = dbSet.Update(oldProfession).Entity;

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
            var profession = dbSet.Include(p => p.ExpertSkills).FirstOrDefault(p => p.Id == professionId);
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
            if(!profession.ExpertSkills.Contains(skill))
            {
                profession.ExpertSkills.Add(skill);
                db.SaveChanges();
            }
        }
        public void RemoveSkillFromProfession(int professionId,int skillId)
        {
            // Find profession
            var profession = dbSet.Include(p => p.ExpertSkills).FirstOrDefault(p => p.Id == professionId);
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
            if(profession.ExpertSkills.Contains(skill))
            {
                profession.ExpertSkills.Remove(skill);
                db.SaveChanges();
            }
        }
        public void ChangeBindingProfessionSkillsData(int professionId,IEnumerable<int> skillIds)
        {
            // Find profession
            var profession = dbSet.Include(p => p.ExpertSkills).FirstOrDefault(p => p.Id == professionId);
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
                    if(profession.ExpertSkills.Contains(skill))
                    {
                        profession.ExpertSkills.Remove(skill);
                    }
                    else
                    {
                        profession.ExpertSkills.Add(skill);
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
        public override async Task<IList<Profession>> AllAsync()
        {
            var data = await dbSet.Include(p => p.ExpertSkills).ToListAsync();
            return data;
        }

        public async Task AddSkillToProfessionAsync(int professionId,int skillId)
        {
            // Find profession
            var profession = await dbSet.Include(p => p.ExpertSkills).FirstOrDefaultAsync(p => p.Id == professionId);
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
            if(!profession.ExpertSkills.Contains(skill))
            {
                profession.ExpertSkills.Add(skill);
                await db.SaveChangesAsync();
            }
        }
        public async Task RemoveSkillFromProfessionAsync(int professionId,int skillId)
        {
            // Find profession
            var profession = await dbSet.Include(p => p.ExpertSkills).FirstOrDefaultAsync(p => p.Id == professionId);
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
            if(profession.ExpertSkills.Contains(skill))
            {
                profession.ExpertSkills.Remove(skill);
                await db.SaveChangesAsync();
            }
        }
        public async Task ChangeBindingProfessionSkillsDataAsync(int professionId,IEnumerable<int> skillIds)
        {
            // Find profession
            var profession = await dbSet.Include(p => p.ExpertSkills).FirstOrDefaultAsync(p => p.Id == professionId);
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
                    if(profession.ExpertSkills.Contains(skill))
                    {
                        profession.ExpertSkills.Remove(skill);
                    }
                    else
                    {
                        profession.ExpertSkills.Add(skill);
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

        public async Task<Profession> AddProfessionWithSkillsAsync(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills)
        {
            
            foreach(var id in beginnerSkills)
            {
                var skill = CheckSkill(id);
                profession.BeginnerSkills.Add(skill);
            }

            foreach(var id in advancedSkills)
            {
                var skill = CheckSkill(id);
                profession.AdvancedSkills.Add(skill);
            }

            foreach(var id in expertSkills)
            {
                var skill = CheckSkill(id);
                profession.ExpertSkills.Add(skill);
            }

            profession = (await dbSet.AddAsync(profession)).Entity;

            try
            {
                await db.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                logger.LogDebug("Error while saving changes",ex);
                throw new DataException("Error while saving changes",ex);
            }
            return profession;
        }

        public async Task<Profession> UpdateProfessionWithSkillsAsync(Profession profession,List<int> beginnerSkills,List<int> advancedSkills,List<int> expertSkills)
        {
            var oldProfession = await dbSet
                .Include(p => p.ExpertSkills)
                .Include(p => p.AdvancedSkills)
                .Include(p => p.BeginnerSkills)
                .FirstOrDefaultAsync(p => p.Id == profession.Id);

            if(oldProfession == null)
            {
                throw new DataException("Profession not found");
            }
            ChangeSkills(oldProfession.BeginnerSkills,beginnerSkills);
            ChangeSkills(oldProfession.AdvancedSkills,advancedSkills);
            ChangeSkills(oldProfession.ExpertSkills,expertSkills);
            /*
                        var oldSkills = oldProfession.ExpertSkills.Select(i => i.Id).ToList();
                        var addSkillsId = skillIds.Except(oldSkills).ToList();
                        var removeSkillsId = oldSkills.Except(skillIds).ToList();

                        foreach(var id in addSkillsId)
                        {
                            var skill = await CheckSkillAsync(id);
                            if(skill != null)
                            {
                                oldProfession.ExpertSkills.Add(skill);
                            }
                        }

                        foreach(var id in removeSkillsId)
                        {
                            var skill = await CheckSkillAsync(id);
                            if(skill != null)
                            {
                                oldProfession.ExpertSkills.Remove(skill);
                            }
                        }
            */
            oldProfession.Name = profession.Name;
            oldProfession.Description = profession.Description;
            oldProfession.Level = profession.Level;
            oldProfession.HpRangeMin = profession.HpRangeMin;
            oldProfession.HpRangeMax = profession.HpRangeMax;
            oldProfession.WizardMana = profession.WizardMana;
            oldProfession.HasWizardMana = profession.HasWizardMana;
            oldProfession.RengerMana = profession.RengerMana;
            oldProfession.HasRengerMana = profession.HasRengerMana;
            oldProfession.AlchemiMana = profession.AlchemiMana;
            oldProfession.HasAlchemiMana = profession.HasAlchemiMana;
            oldProfession.SpecialdMana = profession.SpecialdMana;
            oldProfession.HasSpecialdMana = profession.HasSpecialdMana;

            dbSet.Update(oldProfession);

            try
            {
                await db.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                logger.LogDebug("Error while saving changes",ex);
                throw new DataException("Error while saving changes",ex);
            }
            return oldProfession;
        }
        private async Task<ProfessionSkill> CheckSkillAsync(int id)
        {
            var skill = await db.ProfessionSkill.FirstOrDefaultAsync(ps => ps.Id == id);

            if(skill == null)
            {
                logger.LogWarning($"Skill with id {id} not found");
                return null;
            }
            else
            {
                return skill;
            }
        }

        //------ Private methods --------
        private ProfessionSkill CheckSkill(int id)
        {
            ProfessionSkill skill = db.ProfessionSkill.FirstOrDefault(ps => ps.Id == id);

            if(skill == null)
            {
                logger.LogWarning(String.Format("Skill with id {0} not found",id));
                return null;
            }
            else
            {
                return skill;
            }
        }
        private void ChangeSkills(ICollection<ProfessionSkill> skills,List<int> skillIds )
            {
                List<int> oldSkills = skills.Select(i => i.Id).ToList();

                List<int> addSkillsId = oldSkills.Except(skillIds).ToList();
                List<int> removeSkillsId = skillIds.Except(oldSkills).ToList();

                foreach(var id in addSkillsId)
                {
                    var skill = CheckSkill(id);
                    if(skill != null)
                    {
                        skills.Add(skill);
                    }
                }

                foreach(var id in removeSkillsId)
                {
                    var skill = CheckSkill(id);
                    if(skill != null)
                    {
                        skills.Remove(skill);
                    }
                }
            }
        



    }
}
