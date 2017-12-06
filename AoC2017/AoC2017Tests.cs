using System;
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
                var input = new[] { 2, 4, 1, 2 };
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
                var input = new[] { 3, 1, 2, 3 };
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
                var input = new[] { 0, 2, 3, 4 };
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
                var input = new[] { 1, 3, 4, 1 };
                var day = new Day6();

                var result = day.Iterate(input);

                result[0].ShouldBe(2);
                result[1].ShouldBe(4);
                result[2].ShouldBe(1);
                result[3].ShouldBe(2);
            }
        }
    }
}
