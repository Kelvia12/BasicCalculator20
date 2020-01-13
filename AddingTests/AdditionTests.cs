using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adding.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        Adding add = new Adding();
        private readonly int a = 5;
        private readonly int b = 5;

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(10, add.Add(a, b));
        }

        [TestMethod()]
        public void AddTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SumTest()
        {
            Assert.Fail();
        }
    }
}