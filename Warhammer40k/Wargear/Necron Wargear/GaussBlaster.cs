using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear.Necron_Wargear
{
    class GaussBlaster : RangedWeaponWargearBase
    {
        public GaussBlaster()
        {
            Name = "Guass Blaster";
            Range = 30;
            Type = WeaponTypes.RapidFire;
            NumberOfAttacks = 1;
            Strength = "5";
            ArmorPenetration = -2;
            Damage = 1;
        }
    }
}
