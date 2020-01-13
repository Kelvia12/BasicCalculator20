using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multiply.Tests
{
    [TestClass()]
    public class MultiplyTests
    {
        Multiple multiply = new Multiple();
        private readonly dynamic a = 40;
        private readonly dynamic b = 2;
        private readonly Multiple Multiplyobj = new Multiple();
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(80, Multiplyobj.Multiply(a, b));
        }
    }
}