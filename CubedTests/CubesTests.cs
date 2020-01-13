using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cubed;
using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace Cubed.Tests
{
    [TestClass()]
    public class CubedTests
    {
        Cube cubed = new Cube();
        private readonly double a = 10;
        private readonly Cube Cubedobj = new Cube();
        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(1000, Cubedobj.Cubed(a));
        }
    }
}