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

        private readonly dynamic a = 200;
        private readonly dynamic b = 100;
        [TestMethod()]
        public void SubtractionTest()
        {
            Assert.AreEqual(100, Sub.);
        }
    }
}