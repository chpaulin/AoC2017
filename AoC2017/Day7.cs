using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC2017.Properties;

namespace AoC2017
{
    public class Day7 : IDay
    {
        public void Execute()
        {
            var input = Resources.Day7Input;
            var result1 = Run(input);

            Console.WriteLine("--------------------------");
            Console.WriteLine("       DAY 7 - Part1      ");
            Console.WriteLine("--------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Result: {result1}");

            var result2 = Run2(input);

            Console.WriteLine("--------------------------");
            Console.WriteLine("       DAY 7 - Part2      ");
            Console.WriteLine("--------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Result: {result2}");
        }

        public int Run2(string input)
        {
            var executables = GetExecutables(input);

            PopulateChildLists(executables);

            var rootExecutable = GetRootExecutable(executables);

            var diviatingExe = GetDiviatingChildWeightExecutable(rootExecutable);

            return diviatingExe.Executable.Weight - diviatingExe.Diviation;
        }

        public string Run(string input)
        {
            var executables = GetExecutables(input);

            PopulateChildLists(executables);

            var rootExecutable = GetRootExecutable(executables);

            return rootExecutable.Name;
        }

        public void PopulateChildLists(IReadOnlyList<Executable> executables)
        {
            foreach (var executable in executables)
            {
                executable.Children = GetChildren(executable, executables);
            }
        }

        public IReadOnlyList<Executable> GetChildren(Executable executable, IReadOnlyList<Executable> executables)
        {
            var results = new List<Executable>();

            if (!executable.Entry.Contains("->"))
                return results;

            var children = executable.Entry.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).Last().Trim()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(c => c.Trim());

            foreach (var child in children)
            {
                results.Add(executables.FirstOrDefault(e => e.Name.Equals(child)));
            }

            return results;
        }

        public IReadOnlyList<Executable> GetExecutables(string input)
        {
            var list = new List<Executable>();

            using (var reader = new StringReader(input))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var executable = new Executable
                    {
                        Name = line.Split(' ').First(),
                        Weight = int.Parse(line.Split(')').First().Split('(').Last()),
                        Entry = line
                    };

                    list.Add(executable);

                    line = reader.ReadLine();
                }
            }

            return list;
        }

        public Executable GetRootExecutable(IReadOnlyList<Executable> executables)
        {
            var depthAnalysis = executables.Select(e => new { Depth = GetChildDepth(e), Executable = e }).OrderByDescending(d => d.Depth);

            return depthAnalysis.First().Executable;
        }

        public int GetChildDepth(Executable executable)
        {
            if (executable.Children.Any())
            {
                return 1 + executable.Children.Max(GetChildDepth);
            }

            return 0;
        }

        public int GetExecutableWeight(Executable executable)
        {
            return executable.Weight + executable.Children.Sum(GetExecutableWeight);
        }

        public DiviatingExecutable GetDiviatingChildWeightExecutable(Executable exe)
        {
            var weightDistribution =
                exe.Children.Select(c => new { TotalWeight = GetExecutableWeight(c), Executable = c });

            var groupedWeightDistribution = weightDistribution.GroupBy(d => d.TotalWeight);

            if (groupedWeightDistribution.Count() > 1)
            {
                var ordered = weightDistribution.OrderByDescending(d => d.TotalWeight);
                var divitatingExecutable = ordered.First();

                var childDiviator = GetDiviatingChildWeightExecutable(divitatingExecutable.Executable);

                if (childDiviator != null)
                    return childDiviator;

                return new DiviatingExecutable
                {
                    Executable = divitatingExecutable.Executable,
                    Diviation = divitatingExecutable.TotalWeight - ordered.Select(e => e.TotalWeight).Last()
                };
            }

            return exe.Children.Select(GetDiviatingChildWeightExecutable).FirstOrDefault(d => d != null);
        }
    }

    public class Executable
    {
        public string Name { get; set; }
        public string Entry { get; set; }
        public IReadOnlyList<Executable> Children { get; set; } = new List<Executable>();
        public int Weight { get; set; }
    }

    public class DiviatingExecutable
    {
        public int Diviation { get; set; }
        public Executable Executable { get; set; }
    }
}
