using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 5;
        private readonly double b = 10.8;
        [TestMethod()]
        public void SqrTest()
        {
            Assert.AreEqual(25, Square.Sqr(a));
        }

        [TestMethod()]
        public void SqrDoubleTest()
        {
            Assert.AreEqual(116.64000000000001, Square.Sqr(b));
        }
    }
}