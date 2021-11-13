using System;
using System.Collections.Generic;
using System.Text;
using Warhammer40k.Wargear;

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
        public Dictionary<string, WargearBase> Wargear { get; set; }

        

        public void ReplaceWargear(List<WargearBase> oldWargear, List<WargearBase> newWargear)
        {
            if (!ValidateWargear(oldWargear, newWargear))
                return;

            foreach (var item in oldWargear)
                Wargear.Remove(item.Name);

            foreach (var item in newWargear)
                Wargear.Add(item.Name, item);
        }

        private bool ValidateWargear(List<WargearBase> oldWargear, List<WargearBase> newWargear)
        {
            if (HasWargear(newWargear))
            {
                Console.WriteLine($"Model #{ID} already has some or all of this wargear");
                return false; ;
            }


            if (!HasWargear(oldWargear))
            {
                Console.WriteLine($"Model #{ID} can't replace some or all of the wargear because it is not using it");
                return false; ;
            }

            return true;
        }

        private bool HasWargear(List<WargearBase> wargear)
        {
            foreach (var item in wargear)
            {
                if (!Wargear.ContainsKey(item.Name))
                    return false;
            }

            return true;
        }

        public abstract void SetDefaultWargear();
    }
}
