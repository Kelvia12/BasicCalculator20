using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 15;
        private readonly double b = 9;
        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(3375, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(729, Cube.Cubed(b));
        }
    }
}