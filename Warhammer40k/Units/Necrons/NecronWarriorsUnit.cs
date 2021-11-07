using System;
using System.Collections.Generic;
using System.Text;

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
        public NecronWarriorsModel()
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
    }
}
