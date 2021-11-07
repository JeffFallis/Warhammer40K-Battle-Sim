using System;
using System.Collections.Generic;
using System.Text;
using Warhammer40k.Units;

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
        public Dictionary<string, object> WarGear { get; set; }
        public Dictionary<string, object> Abilities { get; set; }
        public Dictionary<string, object> FactionKeywords { get; set; }
        public Dictionary<string, object> KeyWords { get; set; }

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

        public void DestroyUnit()
        {
            for (int i = 0; i < StartingStrength; i++)
                Models[i] = null;

            Models = null;
        }

        public abstract void SetPowerRating();
    }
}
