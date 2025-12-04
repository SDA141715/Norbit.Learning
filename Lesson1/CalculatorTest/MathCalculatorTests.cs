using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator = CalculatorLibrary.MathCalculator;

namespace CalculatorLibrary.Tests
{
    [TestClass()]
    public class MathCalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var result = Calculator.Add(10, 10);
            Assert.Fail();
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.Fail();
        }
    }
}