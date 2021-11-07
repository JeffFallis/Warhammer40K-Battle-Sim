using System;
using Warhammer40k.Units.Necrons;

namespace Warhammer40k
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitBase necronWarriors = new NecronWarriorsUnit(15);

            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
           
        }
    }
}
