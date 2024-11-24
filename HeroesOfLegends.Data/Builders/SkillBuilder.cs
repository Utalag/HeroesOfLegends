using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;

namespace HeroesOfLegends.Data.Builders
{
    public abstract class SkillBuilder<T> where T : BaseSpecificSkill, new()
    {

        protected T skill;
        public List<bool> IsValid { get; private set;} = new List<bool>();

        protected SkillBuilder()
        {
            skill = new T();
        }

        public  SkillBuilder<T> SetName(string name)
        {
            skill.InternalName = name;
            return this;
        }

        public SkillBuilder<T> SetProfessionSkillId(int id)
        {
            skill.ProfessionSkillId = id;
            return this;
        }

        public  SkillBuilder<T> SetId(int id)
        {
            skill.Id = id;
            return this;
        }

        public SkillBuilder<T> SetLevel(int level)
        {
            skill.Level = level;
            return this;
        }

        public virtual SkillBuilder<T> SetDescription(string description)
        {
            skill.SpecificDescription = description;
            return this;
        }

        public SkillBuilder<T> SetProfessionClass(ProfessionClassEnum profession)
        {
            skill.ProfessionClass = profession;
            return this;
        }

        public SkillBuilder<T> SetLevelGroup(LevelGroupEnum group)
        {
            skill.LevelGroup = group;
            return this;
        }

        public SkillBuilder<T> SetSkillPoint(int points)
        {
            skill.SkillSumPrice = points;
            return this;
        }

        public virtual T Build()
        {
            return skill;
        }

        public virtual BuildResult<T> BuildResult()
        {
            var entiteType = typeof(T).Name;
            var errorMessageList = SetErrorMessage(skill);

            if(errorMessageList.Count > 0)
            {
                return new BuildResult<T>
                {
                    IsSuccess = false,
                    ErrorMessage =String.Format("{0}: {1}",entiteType,string.Join("\n",errorMessageList)),
                    Errors = errorMessageList,
                    Result = skill
                };
            }

            return new BuildResult<T>
            {
                IsSuccess = true,
                Result = skill
            };
        }

        protected virtual List<string> SetErrorMessage(T skill)
        {
            var errorMessages = new List<string>();

            if(string.IsNullOrEmpty(skill.InternalName))
            {
                errorMessages.Add("Name is not set.");
            }
            if(skill.ProfessionSkillId <= 0)
            {
                errorMessages.Add("Profession skill id is not set.");
            }
            if(skill.Level <= 0)
            {
                errorMessages.Add("Level must be greater than 0.");
            }
            if(string.IsNullOrEmpty(skill.SpecificDescription))
            {
                errorMessages.Add("Description is not set.");
            }
            if(skill.ProfessionClass == 0)
            {
                errorMessages.Add("Profession class is not set.");
            }
            if(skill.LevelGroup == 0)
            {
                errorMessages.Add("Level group is not set.");
            }
            //if(skill.SkillSumPrice <= 0)
            //{
            //    errorMessages.Add("Skill points must be greater than 0.");
            //}

            return errorMessages;
        }
    }
}
