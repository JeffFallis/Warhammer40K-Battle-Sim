using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear
{
    class GaussFlayer : RangedWeaponWargearBase
    {
        public GaussFlayer()
        {
            Name = "Guass Flayer";
            Range = 24;
            Type = WeaponTypes.RapidFire;
            NumberOfAttacks = 1;
            Strength = "4";
            ArmorPenetration = -1;
            Damage = 1;
        }
    }
}
