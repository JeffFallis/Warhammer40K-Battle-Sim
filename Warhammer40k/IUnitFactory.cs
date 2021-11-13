using System;
using System.Collections.Generic;
using System.Text;
using Warhammer40k.Units.Necrons;

namespace Warhammer40k
{
    interface IUnitFactory
    {
        public UnitBase Create(Type unitType, int numberOfModels);
    }
}
