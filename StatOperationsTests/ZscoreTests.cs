using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    private readonly int datapoint = 2;
    private readonly double mean = 3.0;
    private readonly double standiv = 1.87;
    [TestClass()]
    public class ZscoreTests
    {
        [TestMethod()]
        public void ZScoreTest()
        {
            Assert.AreEqual(-0.53, Zscore.ZScore(datapoint, mean, standiv));
        }
    }
}