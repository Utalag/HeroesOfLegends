using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesOfLegends.Businsess.Models
{
    public enum AtributEnum
    {
        [Display(Name = "Síla")]
        strength = 0,
        [Display(Name = "Obratnost")]
        agility = 1,
        [Display(Name = "Odolnost")]
        constitution = 2,
        [Display(Name = "Inteligence")]
        intelligence = 3,
        [Display(Name = "Charisma")]
        charisma = 4
    }

    public static class StaticData
    {
        public static Dictionary<int,int> AtributBonus { get; } = new Dictionary<int,int>()
        {
            [1] = -5,
            [2] = -4,
            [3] = -4,
            [4] = -3,
            [5] = -3,
            [6] = -2,
            [7] = -2,
            [8] = -1,
            [9] = -1,
            [10] = 0,
            [11] = 0,
            [12] = 0,
            [13] = 1,
            [14] = 1,
            [15] = 2,
            [16] = 2,
            [17] = 3,
            [18] = 3,
            [19] = 4,
            [20] = 4,
            [21] = 5,
            [22] = 5,
            [23] = 7,
            [24] = 7,
            [25] = 8,
            [26] = 8,
            [27] = 9,
            [28] = 9,
            [29] = 10,
            [30] = 10,
        };

        // atribute labels (CZ: názvy atributů)
        public static string StrengthLabel { get => "Síla"; }
        public static string AgilityLabel { get => "Obratnost"; }
        public static string ConstitutionLabel { get => "Odolnost"; }
        public static string IntelligenceLabel { get => "Inteligence"; }
        public static string CharismaLabel { get => "Charisma"; }


    }
}
