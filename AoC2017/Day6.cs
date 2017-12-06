using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017
{
    public class Day6 : IDay
    {
        public void Execute()
        {
            var input = "2	8	8	5	4	2	3	1	5	5	1	2	15	13	5	14";
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
            var numbers = input.Split(new[] {'\t'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var seen = new List<string>();

            string resultString = input;

            int count = 0;

            while (!seen.Any(v => v.Equals(resultString)))
            {
                count++;

                seen.Add(resultString);

                var result = Iterate(numbers);

                resultString = string.Join("\t", result);
            }

            return count;
        }

        public int[] Iterate(int[] input)
        {
            var top = input.Max();

            var position = input.ToList().IndexOf(top);

            input[position] = 0;

            while (top > 0)
            {
                position = (position + 1) % input.Length;

                input[position] += 1;

                top--;
            }

            return input;
        }
    }
}
