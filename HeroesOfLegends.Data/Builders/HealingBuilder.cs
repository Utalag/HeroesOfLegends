using HeroesOfLegends.Data.Models.SkillsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Data.Builders
{
    public class HealingBuilder : SkillBuilder<Healing>
    {
        public HealingBuilder() : base()
        {
        }

        public HealingBuilder SetMaxHP(int hp)
        {
            skill.MaxHealingPoints = hp;
            SetDescription();
            return this;
        }

        public HealingBuilder SetSpeedHealing(int sm)
        {
            skill.SpeedOfHealing = sm;
            SetDescription();
            return this;
        }

        public HealingBuilder SetDescription()
        {
            skill.SpecificDescription = String.Format("Postava si může vyléčit {0} Hp za {1} směnu, maximálně {2} Hp",skill.MaxHealingPoints,skill.SpeedOfHealing);
            return this;
        }

        protected override List<string> SetErrorMessage(Healing skill)
        {
            var errorMessages = base.SetErrorMessage(skill);

            // Přidání vlastní validace
            if(skill.MaxHealingPoints <= 0)
            {
                errorMessages.Add("MaxHealingPoints property must be greater than 0.");
            }

            if(skill.SpeedOfHealing <= 0)
            {
                errorMessages.Add("SpeedOfHealing property must be greater than 0.");
            }

            return errorMessages;
        }
    }
}
