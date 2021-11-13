using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear
{
    abstract class RangedWeaponWargearBase : WargearBase
    {
        public int Range { get; set; }
        public WeaponTypes Type { get; set; }
        public int NumberOfAttacks { get; set; }
    }
}
