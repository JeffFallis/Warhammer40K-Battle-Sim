using System;
using System.Collections.Generic;
using System.Text;
using Warhammer40k.Units;
using Warhammer40k.Wargear;

namespace Warhammer40k
{
    abstract class UnitBase
    {
        public static int IDCounter = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public Factions Faction { get; set; }
        public BattlefieldRoles BattlefieldRole { get; set; }
        public int PowerRating { get; set; }
        public int Points { get; set; }
        public int MinUnitNum { get; set; }
        public int MaxUnitNum { get; set; }
        public int StartingStrength { get; set; }
        public bool UnderStrengthUnit { get; set; }
        public List<ModelBase> Models { get; set; }
        public Dictionary<string, WargearBase> Wargear { get; set; }
        public Dictionary<string, object> Abilities { get; set; }
        public Dictionary<string, object> FactionKeywords { get; set; }
        public Dictionary<string, object> KeyWords { get; set; }

        private static Dictionary<string, WargearBase> _validWargear;

        public void SetStartingStrength(int numberOfUnits)
        {
            if (numberOfUnits < MinUnitNum)
                UnderStrengthUnit = true;

            if (numberOfUnits > MaxUnitNum)
                numberOfUnits = MaxUnitNum;

            StartingStrength = numberOfUnits;
        }

        public void SetModelsList<T>() where T : ModelBase, new()
        {
            Models = new List<ModelBase>();

            for (int i = 0; i < StartingStrength; i++)
                Models.Add(new T());
        }

        public void AssignCustomWargear(List<WargearBase> oldWargear, List<WargearBase> newWargear, int numOfUnits)
        {
            if (!ValidateWargear(newWargear))
                return;

            if (numOfUnits > StartingStrength)
                numOfUnits = StartingStrength;

            for (int i = 0; i < numOfUnits; i++)
                Models[i].ReplaceWargear(oldWargear, newWargear);
        }

        public bool ValidateWargear(List<WargearBase> newWargear)
        {
            foreach (var item in newWargear)
                if (!_validWargear.ContainsKey(item.Name))
                {
                    Console.Out.WriteLine($"{Name} can not use the {item.Name}");
                    return false;
                }
                    

            return true;
        }

        public void SetValidWargear(List<WargearBase> wargear)
        {
            if (_validWargear != null)
                return;

            _validWargear = new Dictionary<string, WargearBase>();

            foreach (var item in wargear)
                if (!_validWargear.ContainsKey(item.Name))
                    _validWargear.Add(item.Name, item);
        }

        public void DestroyUnit()
        {
            for (int i = 0; i < StartingStrength; i++)
                Models[i] = null;

            Models = null;
        }

        public abstract void SetPowerRatingAndPoints();
    }
}
