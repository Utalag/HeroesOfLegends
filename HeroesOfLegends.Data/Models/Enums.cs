using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOfLegends.Data.Models
{

    // ----------------- Skill -----------------
    public enum SkillClassEnum
    {
        [Display(Name = "Boj")]
        combatSkill,
        [Display(Name = "Magie")]
        magicSkill,
        [Display(Name = "Lov")]
        huntingSkill,
        [Display(Name = "Alchymie")]
        alchemySkill,
        [Display(Name = "Základní")]
        baseSkill,
        [Display(Name = "Ostatní")]
        otherSkill,
        [Display(Name = "Zlodějství")]
        thiefSkill,
        [Display(Name = "Životy")]
        health,
        [Display(Name = "Vše")]
        allSkill = combatSkill | magicSkill | huntingSkill | alchemySkill | baseSkill | otherSkill | thiefSkill | health,
    }

    //profesion class and subclass
    public enum ProfessionClassEnum
    {
        health,
        [Display(Name = "Válečník")]
        N_warrior,
        [Display(Name = "Šermíř")]
        swordsman,
        [Display(Name = "Zápasník")]
        fightre,
        [Display(Name = "Bojovník")]
        champion,


        [Display(Name = "Kouzelník")]
        N_wizard,
        [Display(Name = "Mág")]
        mage,
        [Display(Name = "Čaroděj")]
        sorcerer,

        [Display(Name = "Lovec")]
        N_hunter,
        [Display(Name = "Hraničář")]
        renger,
        [Display(Name = "Druid")]
        druid,


        [Display(Name = "Alchymista")]
        N_alchemist,
        [Display(Name = "Parofor")]
        pyrofor,
        [Display(Name = "Theurg")]
        theurg,

        [Display(Name = "Zloděj")]
        N_thief,
        [Display(Name = "Vrah")]
        assassin,
        [Display(Name = "Sicco")]
        sicco,
        [Display(Name = "Lupič")]
        rogue,

        [Display(Name = "Lukostřelec")]
        archer,

        allBaseClasee = N_warrior | N_wizard | N_hunter,
        allSubclasse = swordsman | fightre | champion | mage | sorcerer | renger | druid | pyrofor | theurg | assassin | sicco | rogue | archer,
        all = N_warrior | swordsman | fightre | champion | N_wizard | mage | sorcerer | N_hunter | renger | druid | N_alchemist | pyrofor | theurg | N_thief | assassin | sicco | rogue | archer,
    }

    // novices, advanced, master
    public enum LevelGroupEnum
    {
        [Display(Name = "Začítečník")]
        novice,
        [Display(Name = "Pokročilý")]
        advenced,
        [Display(Name = "Expert")]
        master,
        [Display(Name = "Pokročilý a Expert")]
        advacedPlus = advenced | master,
        [Display(Name = "Vše")]
        all = novice | advenced | master,


    }


    // ----------------- Weapon -----------------
    public enum CategoryWeaponEnum
    {
        [Display(Name = "Jednoruční")]
        OneHanded,
        [Display(Name = "Obouruční")]
        TwoHanded,
        [Display(Name = "Dvě jednoruční")]
        DualWielding,

        [Display(Name = "Střelní")]
        Fire,
        [Display(Name = "Vrhací")]
        Throwing,

        [Display(Name = "Magické")]
        Magical,
        [Display(Name = "Exotické")]
        Exotic,

        [Display(Name = "Na blízko")]
        Melee = OneHanded | TwoHanded | DualWielding,
        [Display(Name = "Na dálku")]
        Ranged = Fire | Throwing,
    }

    public enum WeaponTypeEnum
    {
        // One-Handed Weapons
        Sword,              // (Cz: Meč)
        Sabre,              // (Cz: Šavle)
        Dagger,             // (Cz: Dýka)
        Hammer,             // (Cz: Kladivo)
        FistWeapon,         // (Cz: Pěstní zbraň)

        // Two-Handed Weapons
        Greatsword,         // (Cz: Velký meč)
        BattleAxe,          // (Cz: Bojová sekera)
        Warhammer,          // (Cz: Válečné kladivo)
        Halberd,            // (Cz: Halapartna)
        Longbow,            // (Cz: Dlouhý luk)

        // Dual-Wielding Weapons
        PairedDaggers,     // (Cz: Párové dýky)
        PairedSabres,       // (Cz: Párové šavle)
        Nunchaku,          // (Cz: Nunchaku)

        // Ranged Weapons
        Bow,                // (Cz: Luk)
        Crossbow,           // (Cz: Kuše)
        Rifle,              // (Cz: Puška)

        // Magical Weapons
        MagicStaff,         // (Cz: Magický prut)
        MagicRing,          // (Cz: Magický prsten)
        Spellbook,          // (Cz: Kniha kouzel)

        // Exotic Weapons
        Katana,             // (Cz: Katana)
        Sai,                // (Cz: Sai)
        BoStaff             // (Cz: Bojový tyč)
    }

    public static class Enums
    {
        public static string GetEnumDisplayName(Enum enumValue)
        {
            var enumType = enumValue.GetType();
            var memberInfo = enumType.GetMember(enumValue.ToString());
            if(memberInfo.Length > 0)
            {
                var displayAttribute = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
                if(displayAttribute != null)
                {
                    return displayAttribute.Name;
                }
            }
            return enumValue.ToString();

        }
    }
}
   
