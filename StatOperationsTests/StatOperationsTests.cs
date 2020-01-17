using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatOperationsTests
    {
        private readonly int[] arrayB = { 1, 2, 3, 4, 5 };
        [TestMethod()]
        public void MeanTest()
        {
            Assert.AreEqual(3, StatOperations.StatOperations.Mean(arrayB));
        }
    }
}