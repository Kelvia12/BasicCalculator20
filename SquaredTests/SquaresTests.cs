using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Squared.Tests
{
    [TestClass()]
    public class SquaredTests
    {
        
        Squares squared = new Squares();
        private readonly double a = 10;
        private readonly Squares Squaredobj = new Squares();
        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(100, Squaredobj.Squared(a));
        }
    }
}