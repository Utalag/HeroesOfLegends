using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Data.Interfaces.ISkills
{
    public interface IHealing
    {
        public int MaxHealingPoints { get; set; }
        public int SpeedOfHealing { get; set; }
    }
}
