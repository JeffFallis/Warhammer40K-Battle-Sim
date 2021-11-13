using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer40k
{
    public class UnitFactory : IUnitFactory
    {
        public UnitBase Create(Type unitType, int numberOfModels)
        {
            UnitBase unit = Activator.CreateInstance(unitType) as UnitBase;

            unit.SetBasicInfo();
            unit.SetValidModels();
            unit.SetStartingStrength(numberOfModels);
            unit.SetPowerRatingAndPoints();
            unit.SetModelsList();

            return unit;
        }
    }
}
