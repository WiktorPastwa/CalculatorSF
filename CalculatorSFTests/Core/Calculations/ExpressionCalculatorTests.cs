using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorSF.Core.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Core.Calculations.Tests
{
    [TestClass()]
    public class ExpressionCalculatorTests
    {
        [TestMethod()]
        public void ShouldCalculate()
        {
            var expression = "2+2";
            var calculator = new ExpressionCalculator();
            var value = calculator.Calculate(expression);
            Assert.AreEqual(4, value);
        }
    }
}