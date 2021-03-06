﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatisticsCalculatorTests
    {
        private readonly int[] arrayB = { 1, 2, 3, 4, 5 };
        
        [TestMethod()]
        public void MeanTest()
        {
            Assert.AreEqual(3, StatOperations.StatOperations.Mean(arrayB));
        }
    }
}