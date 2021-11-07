using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Units
{
    abstract class ModelBase
    {
        public static int IDCounter = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int Movement { get; set; }
        public int WeaponSkill { get; set; }
        public int BallisticSkill { get; set; }
        public int Strength { get; set; }
        public int Toughness { get; set; }
        public int Wounds { get; set; }
        public int Attacks { get; set; }
        public int Leadership { get; set; }
        public int Save { get; set; }
    }
}
