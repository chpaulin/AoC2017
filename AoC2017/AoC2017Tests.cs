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
    }
}
