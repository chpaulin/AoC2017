using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017
{
    public class DayX : IDay
    {
        public void Execute()
        {
            var input = "";
            var result1 = Run(input);

            Console.WriteLine("--------------------------");
            Console.WriteLine("       DAY 1 - Part1      ");
            Console.WriteLine("--------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Result: {result1}");

            var result2 = Run(input);

            Console.WriteLine("--------------------------");
            Console.WriteLine("       DAY 1 - Part2      ");
            Console.WriteLine("--------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Result: {result2}");
        }

        public int Run(string input)
        {
            return 0;
        }
    }
}
