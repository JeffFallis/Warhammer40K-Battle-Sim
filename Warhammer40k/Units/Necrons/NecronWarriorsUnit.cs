using System;
using System.Collections.Generic;
using System.Text;
using Warhammer40k.Wargear;

namespace Warhammer40k.Units.Necrons
{
    class NecronWarriorsUnit : UnitBase
    {
        public NecronWarriorsUnit(int numberOfUnits)
        {
            SetBasicInfo();
            SetStartingStrength(numberOfUnits);
            SetPowerRatingAndPoints();
            SetModelsList<NecronWarriorsModel>();

            // TODO Refactor into factory class when that is made
            List<WargearBase> validWargear = new List<WargearBase>();
            validWargear.Add(new GaussFlayer());
            validWargear.Add(new GaussReaper());
            validWargear.Add(new CloseCombatWeapon());
            SetValidWargear(validWargear);
        }

        private void SetBasicInfo()
        {
            ID = IDCounter++;
            Name = "Necron Warriors";
            Faction = Factions.Necrons;
            BattlefieldRole = BattlefieldRoles.Troops;
            MinUnitNum = 10;
            MaxUnitNum = 20;
        }

        public override void SetPowerRatingAndPoints()
        {
            PowerRating = StartingStrength >= 11 ? 12 : 6;
            Points = 13 * StartingStrength;
        }
    }

    class NecronWarriorsModel : ModelBase
    {
        public NecronWarriorsModel() : base()
        {
            SetBasicInfo();
            SetDefaultWargear();
        }

        public void SetBasicInfo()
        {
            ID = IDCounter++;
            Name = "Necron Warriors";
            Points = 13;
            Movement = 5;
            WeaponSkill = 3;
            BallisticSkill = 3;
            Strength = 4;
            Toughness = 4;
            Wounds = 1;
            Attacks = 1;
            Leadership = 10;
            Save = 3;
        }

        public override void SetDefaultWargear()
        {
            Wargear = new Dictionary<string, WargearBase>();
            Wargear.Add("Guass Flayer", new GaussFlayer());
            Wargear.Add("Close Combat Weapon", new CloseCombatWeapon());
        }
    }
}
