using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear
{
    class GaussReaper : RangedWeaponWargearBase
    {
        public GaussReaper()
        {
            Name = "Guass Reaper";
            Range = 12;
            Type = WeaponTypes.Assault;
            NumberOfAttacks = 2;
            Strength = "5";
            ArmorPenetration = -2;
            Damage = 1;
        }
    }
}
