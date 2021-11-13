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
            UnitBase necronWarriors = new NecronWarriorsUnit(15);
            List<WargearBase> gaussFlayer = new List< WargearBase >();
            gaussFlayer.Add(new GaussFlayer());
            List<WargearBase> gaussReaper = new List<WargearBase>();
            gaussReaper.Add(new GaussReaper());
            List<WargearBase> gaussBlaster = new List<WargearBase>();
            gaussBlaster.Add(new GaussBlaster());
            necronWarriors.AssignCustomWargear(gaussFlayer, gaussBlaster, 15);

            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
           
        }
    }
}
