using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k.Units.Necrons
{
    class NecronWarriorsUnit : UnitBase
    {
        public NecronWarriorsUnit(int numberOfUnits)
        {
            ID = IDCounter++;
            Name = "Necron Warriors";
            Faction = Factions.Necrons;
            BattlefieldRole = BattlefieldRoles.Troops;
            MinUnitNum = 10;
            MaxUnitNum = 20;
            SetStartingStrength(numberOfUnits);
            SetPowerRating();
            SetModelsList<NecronWarriorsModel>();
            Points = 13 * StartingStrength;
        }

        public override void SetPowerRating()
        {
            PowerRating = StartingStrength >= 11 ? 12 : 6;
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
