using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfTipCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WpfTipCalculator.Tests
{
    [TestClass()]
    public class BillTests
    {
        [TestMethod()]
        public void CalcTaxTest1()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void CalcTaxTest2()
        {
            Bill b = new Bill();
            double amount = 100;

            Assert.areEqual(109, bill.CalcTax(), 0);
        }


        [TestMethod()]
        public void CalcTipTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CalcTotalTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BillTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BillTest1()
        {
            Assert.Fail();
        }
    }
}