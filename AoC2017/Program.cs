using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017
{
    class Program
    {
        private static IDay[] _days = new IDay[] { new Day1(), new Day2(), new DayX(), new DayX(), new Day5() };

        static void Main()
        {
            Console.Write("Select day (1-24): ");
            var day = Console.ReadLine();

            var dayInt = int.Parse(day);

            var dayLogic = _days[dayInt - 1];

            dayLogic.Execute();

            Console.ReadLine();
        }
    }
}