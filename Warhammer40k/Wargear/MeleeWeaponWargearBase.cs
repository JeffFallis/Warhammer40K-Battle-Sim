using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear
{
    class MeleeWeaponWargearBase : WargearBase
    {
        public WeaponTypes Type = WeaponTypes.Melee;
        public int range = 0;
    }
}
