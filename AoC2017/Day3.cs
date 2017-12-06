using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017
{
    public class Day3 : IDay
    {
        public void Execute()
        {
            var input = 312051;
            var result1 = Run(input);

            Console.WriteLine("--------------------------");
            Console.WriteLine("       DAY 3 - Part1      ");
            Console.WriteLine("--------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Result: {result1}");

            var result2 = Run(input);

            Console.WriteLine("--------------------------");
            Console.WriteLine("       DAY 3 - Part2      ");
            Console.WriteLine("--------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Result: {result2}");
        }

        public int Run(int input)
        {
            var buckets = new List<int[]>();

            buckets.Add(new int[1]);

            var bucket = 0;

            buckets[bucket][0] = 1;

            var bucketSize = 0;

            var value = 2;

            while (value <= input)
            {
                bucketSize += 8;

                buckets.Add(new int[bucketSize]);
                bucket++;

                for (int i = 0; i < bucketSize; i++)
                {
                    buckets[bucket][i] = value;
                    value++;

                    if (value > input)
                        break;
                }

            }

            //Positions (bucketNo - 1) + n*(bucketsize/4)

            var position = buckets[bucket].ToList().IndexOf(input);

            //Get closest position
            var quarter = bucketSize / 4;
            var first = bucket - 1;
            var second = bucket - 1 + quarter * 1;
            var third = bucket - 1 + quarter * 2;
            var fourth = bucket - 1 + quarter * 3;

            var diff1 = Math.Abs(position - first);
            var diff2 = Math.Abs(position - second);
            var diff3 = Math.Abs(position - third);
            var diff4 = Math.Abs(position - fourth);

            var sorted = new int[] {diff1, diff2, diff3, diff4}.OrderBy(n => n);

            return sorted.First() + bucket;
        }

        
    }
}
