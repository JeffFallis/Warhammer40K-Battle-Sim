using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Wargear
{
    abstract class WargearBase
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public int ArmorPenetration { get; set; }
        public int Damage { get; set; }
        public Dictionary<string, object> Abilities { get; set; }

    }
}
