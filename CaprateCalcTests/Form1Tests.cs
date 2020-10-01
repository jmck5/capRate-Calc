using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapRate_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapRate_Calculator.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void EquationTest()
        {
           
        }

        [TestMethod()]
        public void CalcYearlyFeeTest()
        {
            float amount = 1000;
            float rate = 8.00f;
            int timeSpan = 12;
            float myDelta = (float) 0.001;
            Form1 calc = new Form1();

            Assert.AreEqual(132.695,calc.CalcYearlyFee(amount, rate, timeSpan), myDelta);

            
        }
    }
}

namespace CaprateCalcTests
{
    class Form1Tests
    {
    }
}
