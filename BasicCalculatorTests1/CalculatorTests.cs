using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{

    [TestClass()]
    public class CalculatorTests
    {
        public Calculator calculator = new Calculator();

        [TestMethod()]
        public void AddTest()
        {

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);
        }

        [TestMethod()]
        public void DivideTest()
        {

            double c = calculator.Dividing(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);
        }

        [TestMethod()]
        public void DivideIntDivideZeroTest()
        {

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Dividing(2, 0));
        }

        [TestMethod()]

        public void AddIntDoubleTest()
        {

            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);

        }


    }
}