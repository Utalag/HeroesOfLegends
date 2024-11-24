using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HeroesOfLegends.Data.Interfaces.ISkills
{
    public interface IBaseSkillData
    {
        [Key]
        public int Id { get; set; }
        [Range(1, 32)]
        public int Level { get; set; }  // (Cz: Úroveň od které je možno skill umět)
        public string SpecificDescription { get; set; }
    }


}
