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
                var result = _day.Run("1122");

                result.ShouldBe(3);
            }

            [TestMethod]
            public void Day1_Test2()
            {
                var result = _day.Run("1111");

                result.ShouldBe(4);
            }

            [TestMethod]
            public void Day1_Test3()
            {
                var result = _day.Run("1234");

                result.ShouldBe(0);
            }

            [TestMethod]
            public void Day1_Test4()
            {
                var result = _day.Run("91212129");

                result.ShouldBe(9);
            }
        }
    }
}
