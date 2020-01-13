using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 200;
        private readonly int b = 100;
        private readonly double c = 20.50;
        private readonly double d = 10.40;
        private readonly int[] arrayB = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
        [TestMethod()]
        public void SubTest()
        {
            Assert.AreEqual(100, Subtraction.Sub(a, b));
        }

        [TestMethod()]
        public void SubTest1()
        {
            Assert.AreEqual(10.10, Subtraction.Sub(c, d));
        }

        [TestMethod()]
        public void SumTest3()
        {
            Assert.AreEqual(6, Subtraction.Sub(arrayB));
        }
    }
}