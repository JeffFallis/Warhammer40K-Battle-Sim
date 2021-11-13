using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear
{
    class CloseCombatWeapon : MeleeWeaponWargearBase
    {
        public CloseCombatWeapon()
        {
            Name = "Close Combat Weapon";
            Strength = "User";
            ArmorPenetration = 0;
            Damage = 1;
        }
    }
}
