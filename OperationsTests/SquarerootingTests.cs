using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquarerootingTests
    {
        private readonly double a = 25;
        [TestMethod()]
        public void SquarerootTest()
        {
            Assert.AreEqual(5, Squarerooting.Squareroot(a));
        }
    }
}