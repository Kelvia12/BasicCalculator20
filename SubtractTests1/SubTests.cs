using Microsoft.VisualStudio.TestTools.UnitTesting;
using Subtract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subtract.Tests
{
    [TestClass()]
    public class SubTests
    {
        Sub subtract = new Sub();
        private readonly dynamic a = 15;
        private readonly dynamic b = 20;
        readonly Sub Subobj = new Sub();
        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(-5, Subobj.Difference(a, b));
        }
    }
}