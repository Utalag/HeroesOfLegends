using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Data.Interfaces.IWeapons
{
    public interface IWeaponsType
    {
        public CategoryWeaponEnum CategoryWeapon { get; set; }
    }
}
