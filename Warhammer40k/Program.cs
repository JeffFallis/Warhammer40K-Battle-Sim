using System;
using System.Collections.Generic;
using Warhammer40k.Units.Necrons;
using Warhammer40k.Wargear;
using Warhammer40k.Wargear.Necron_Wargear;

namespace Warhammer40k
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitFactory unitFactory = new UnitFactory();
           var unit = unitFactory.Create(typeof(NecronWarriorsUnit), 15);

            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
           
        }
    }
}
