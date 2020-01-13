using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareRoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRoot.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        Squareroots squareroot = new Squareroots();
        private readonly double a = 25;
        private readonly Squareroots SquareRootobj = new Squareroots();
        [TestMethod()]
        public void SquareRootTest()
        {
            Assert.AreEqual(5, SquareRootobj.Squareroot(a));
        }
    }
}