using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace AoC2017
{
    [TestClass]
    public class AoC2017Tests
    {
        [TestClass]
        public class Day1Tests
        {
            private Day1 _day;

            [TestInitialize]
            public void Initialize()
            {
                _day = new Day1();
            }

            [TestMethod]
            public void Day1_Test1()
            {
                var result = _day.Run("1122", 1);

                result.ShouldBe(3);
            }

            [TestMethod]
            public void Day1_Test2()
            {
                var result = _day.Run("1111", 1);

                result.ShouldBe(4);
            }

            [TestMethod]
            public void Day1_Test3()
            {
                var result = _day.Run("1234", 1);

                result.ShouldBe(0);
            }

            [TestMethod]
            public void Day1_Test4()
            {
                var result = _day.Run("91212129", 1);

                result.ShouldBe(9);
            }

            [TestMethod]
            public void Day1_Test5()
            {
                var result = _day.Run("1212", 2);

                result.ShouldBe(6);
            }

            [TestMethod]
            public void Day1_Test6()
            {
                var result = _day.Run("1221", 2);

                result.ShouldBe(0);
            }

            [TestMethod]
            public void Day1_Test7()
            {
                var result = _day.Run("123425", 3);

                result.ShouldBe(4);
            }

            [TestMethod]
            public void Day1_Test8()
            {
                var result = _day.Run("123123", 3);

                result.ShouldBe(12);
            }

            [TestMethod]
            public void Day1_Test9()
            {
                var result = _day.Run("12131415", 4);

                result.ShouldBe(4);
            }
        }

        [TestClass]
        public class Day2Tests
        {
            private Day2 _day;

            [TestInitialize]
            public void Initialize()
            {
                _day = new Day2();
            }

            [TestMethod]
            public void Day2_Test1()
            {
                var input = "5\t1\t9\t5\r\n7\t5\t3\r\n2\t4\t6\t8";

                var result = _day.Run(input);

                result.ShouldBe(18);
            }

            [TestMethod]
            public void Day2_Test2()
            {
                var input = "5\t9\t2\t8\r\n9\t4\t7\t3\r\n3\t8\t6\t5";

                var result = _day.Run2(input);

                result.ShouldBe(9);
            }
        }

        [TestClass]
        public class Day3Tests
        {
            [TestMethod]
            public void Day3_Test1()
            {
                var day = new Day3();
                var input = 1;

                var result = day.Run(input);

                result.ShouldBe(0);
            }

            [TestMethod]
            public void Day3_Test2()
            {
                var day = new Day3();
                var input = 12;

                var result = day.Run(input);

                result.ShouldBe(3);
            }

            [TestMethod]
            public void Day3_Test3()
            {
                var day = new Day3();
                var input = 23;

                var result = day.Run(input);

                result.ShouldBe(2);
            }

            [TestMethod]
            public void Day3_Test4()
            {
                var day = new Day3();
                var input = 1024;

                var result = day.Run(input);

                result.ShouldBe(31);
            }
        }

        [TestClass]
        public class Day5Tests
        {
            private Day5 _day;

            [TestInitialize]
            public void Initialize()
            {
                _day = new Day5();
            }

            [TestMethod]
            public void Day5_Test1()
            {
                var input = "0\r\n3\r\n0\r\n1\r\n-3";

                var result = _day.Run(input, int.MaxValue);

                result.ShouldBe(5);
            }

            [TestMethod]
            public void Day5_Test2()
            {
                var input = "0\r\n3\r\n0\r\n1\r\n-3";

                var result = _day.Run(input, 3);

                result.ShouldBe(10);
            }
        }

        [TestClass]
        public class Day6Tests
        {
            [TestMethod]
            public void Day6_Test1()
            {
                var input = "0\t2\t7\t0";
                var day = new Day6();

                var result = day.Run(input);

                result.ShouldBe(5);
            }

            [TestMethod]
            public void Day6_Test2()
            {
                var input = "0\t2\t7\t0";
                var day = new Day6();

                var result = day.Run2(input);

                result.ShouldBe(4);
            }

            [TestMethod]
            public void Day6_IterateTest1()
            {
                var input = new[] {0, 2, 7, 0};
                var day = new Day6();

                var result = day.Iterate(input);

                result[0].ShouldBe(2);
                result[1].ShouldBe(4);
                result[2].ShouldBe(1);
                result[3].ShouldBe(2);
            }

            [TestMethod]
            public void Day6_IterateTest2()
            {
                var input = new[] {2, 4, 1, 2};
                var day = new Day6();

                var result = day.Iterate(input);

                result[0].ShouldBe(3);
                result[1].ShouldBe(1);
                result[2].ShouldBe(2);
                result[3].ShouldBe(3);
            }

            [TestMethod]
            public void Day6_IterateTest3()
            {
                var input = new[] {3, 1, 2, 3};
                var day = new Day6();

                var result = day.Iterate(input);

                result[0].ShouldBe(0);
                result[1].ShouldBe(2);
                result[2].ShouldBe(3);
                result[3].ShouldBe(4);
            }

            [TestMethod]
            public void Day6_IterateTest4()
            {
                var input = new[] {0, 2, 3, 4};
                var day = new Day6();

                var result = day.Iterate(input);

                result[0].ShouldBe(1);
                result[1].ShouldBe(3);
                result[2].ShouldBe(4);
                result[3].ShouldBe(1);
            }

            [TestMethod]
            public void Day6_IterateTest5()
            {
                var input = new[] {1, 3, 4, 1};
                var day = new Day6();

                var result = day.Iterate(input);

                result[0].ShouldBe(2);
                result[1].ShouldBe(4);
                result[2].ShouldBe(1);
                result[3].ShouldBe(2);
            }
        }

        [TestClass]
        public class Day7Tests
        {
            [TestMethod]
            public void Day7_Test1()
            {
                var input =
                    @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";
                var day = new Day7();

                var bottomProgram = day.Run(input);

                bottomProgram.ShouldBe("tknk");
            }
        }

        [TestMethod]
        public void Day7_GetExecutables()
        {
            var input =
                @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";
            var day = new Day7();

            var results = day.GetExecutables(input);

            results.Count.ShouldBe(13);
            results.First().Name.ShouldBe("pbga");
            results.First().Weight.ShouldBe(66);
        }

        [TestMethod]
        public void Day7_GetChildrenFromEntry()
        {
            var input = "fwft (72) -> ktlj, cntj, xhth";

            var day = new Day7();

            var exe = new Executable {Name = "fwft", Entry = input};

            var executables = new List<Executable>(new[]
            {
                exe,
                new Executable {Name = "ktlj"},
                new Executable {Name = "cntj"},
                new Executable {Name = "xhth"},
            });

            var results = day.GetChildren(exe, executables);

            results.Count.ShouldBe(3);
            results.ShouldContain(c => c.Name == "ktlj");
            results.ShouldContain(c => c.Name == "cntj");
            results.ShouldContain(c => c.Name == "xhth");
        }

        [TestMethod]
        public void Day7_GetChildrenFromEntryWhenNone()
        {
            var input = "ktlj (57)";

            var day = new Day7();

            var exe = new Executable {Name = "ktlj", Entry = input};

            var executables = new List<Executable>(new[]
            {
                exe,
                new Executable {Name = "cntj"},
                new Executable {Name = "xhth"},
            });

            var results = day.GetChildren(exe, executables);

            results.Count.ShouldBe(0);
        }

        [TestMethod]
        public void Day7_PopulateChildListsWithThreeLevels()
        {

            var day = new Day7();

            var executables = new List<Executable>(new[]
            {
                new Executable {Name = "fwft", Entry = "fwft (72) -> ktlj"},
                new Executable {Name = "ktlj", Entry = "ktlj (57) -> cntj"},
                new Executable {Name = "cntj", Entry = "cntj (57) -> xhth"},
                new Executable {Name = "xhth", Entry = "xhth (57)"},
            });

            day.PopulateChildLists(executables);

            executables[0].Children.Count.ShouldBe(1);
            executables[0].Children.ShouldContain(c => c.Name == "ktlj");
            executables[1].Children.Count.ShouldBe(1);
            executables[1].Children.ShouldContain(c => c.Name == "cntj");
            executables[2].Children.Count.ShouldBe(1);
            executables[2].Children.ShouldContain(c => c.Name == "xhth");
            executables[3].Children.Count.ShouldBe(0);
        }

        [TestMethod]
        public void Day7_PopulateChildLists()
        {
            var input = "fwft (72) -> ktlj, cntj, xhth";

            var day = new Day7();

            var exe = new Executable {Name = "fwft", Entry = input};

            var executables = new List<Executable>(new[]
            {
                exe,
                new Executable {Name = "ktlj", Entry = "ktlj (57)"},
                new Executable {Name = "cntj", Entry = "cntj (57)"},
                new Executable {Name = "xhth", Entry = "xhth (57)"},
            });

            day.PopulateChildLists(executables);

            exe.Children.Count.ShouldBe(3);
            exe.Children.ShouldContain(c => c.Name == "ktlj");
            exe.Children.ShouldContain(c => c.Name == "cntj");
            exe.Children.ShouldContain(c => c.Name == "xhth");
        }

        [TestMethod]
        public void Day7_GetRootExecutable()
        {
            var day = new Day7();

            var child1 = new Executable {Name = "ktlj", Entry = "ktlj (57)"};
            var child2 = new Executable {Name = "cntj", Entry = "cntj (57)"};
            var child3 = new Executable {Name = "xhth", Entry = "xhth (57)"};

            var root = new Executable
            {
                Name = "fwft",
                Entry = "fwft (72) -> ktlj, cntj, xhth",
                Children = new List<Executable>(new[] {child1, child2, child3})
            };

            var executables = new List<Executable>(new[]
            {
                root,
                child1,
                child2,
                child3,
            });

            var result = day.GetRootExecutable(executables);

            result.ShouldBe(root);
        }

        [TestMethod]
        public void Day7_GetChildDepth()
        {
            var day = new Day7();

            var child1 = new Executable {Name = "ktlj", Entry = "ktlj (57)"};
            var child2 = new Executable {Name = "cntj", Entry = "cntj (57)"};
            var child3 = new Executable {Name = "xhth", Entry = "xhth (57)"};

            var root = new Executable
            {
                Name = "fwft",
                Entry = "fwft (72) -> ktlj, cntj, xhth",
                Children = new List<Executable>(new[] {child1, child2, child3})
            };

            var result = day.GetChildDepth(root);

            result.ShouldBe(1);
        }

        [TestMethod]
        public void Day7_GetExecutableWeight()
        {
            var input = "fwft (72) -> ktlj, cntj, xhth";

            var day = new Day7();

            var children = new List<Executable>(new[]
            {
                new Executable {Name = "ktlj", Entry = "ktlj (57)", Weight = 57},
                new Executable {Name = "cntj", Entry = "cntj (57)", Weight = 57},
                new Executable {Name = "xhth", Entry = "xhth (57)", Weight = 57},
            });

            var exe = new Executable {Name = "fwft", Entry = input, Weight = 72, Children = children};

            var weight = day.GetExecutableWeight(exe);

            weight.ShouldBe(243);
        }

        [TestMethod]
        public void Day7_GetDiviatingChildWeightExecutable()
        {            
            var day = new Day7();

            var children_ugml = new List<Executable>(new[]
            {
                new Executable {Name = "gyxo", Entry = "ugml (61)", Weight = 61},
                new Executable {Name = "ebii", Entry = "padx (61)", Weight = 61},
                new Executable {Name = "jptl", Entry = "fwft (61)", Weight = 61},
            });

            var children_padx = new List<Executable>(new[]
            {
                new Executable {Name = "pbga", Entry = "pbga (66)", Weight = 66},
                new Executable {Name = "havc", Entry = "havc (66)", Weight = 66},
                new Executable {Name = "qoyq", Entry = "qoyq (66)", Weight = 66},
            });

            var children_fwft = new List<Executable>(new[]
            {
                new Executable {Name = "ktlj", Entry = "ktlj (57)", Weight = 57 },
                new Executable {Name = "cntj", Entry = "cntj (57)", Weight = 57 },
                new Executable {Name = "xhth", Entry = "xhth (57)", Weight = 57 },
            });

            var ugml = new Executable
            {
                Name = "ugml",
                Entry = "ugml (68)",
                Weight = 68,
                Children = children_ugml
            };

            var childrenRoot = new List<Executable>(new[]
            {
                ugml,
                new Executable {Name = "padx", Entry = "padx (45)", Weight = 45, Children = children_padx},
                new Executable {Name = "fwft", Entry = "fwft (72)", Weight = 72, Children = children_fwft},
            });

            var root = new Executable { Name = "tknk", Entry = "tknk (41) -> ugml, padx, fwft", Weight = 41, Children = childrenRoot };

            var diviatingExecutable = day.GetDiviatingChildWeightExecutable(root);

            diviatingExecutable.Executable.ShouldBe(ugml);
            diviatingExecutable.Diviation.ShouldBe(8);
        }
    }
}
