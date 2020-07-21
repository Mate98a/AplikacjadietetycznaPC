using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplikacjaDietetyczna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaDietetyczna.Tests
{
    [TestClass()]
    public class BmrTests
    {
        [TestMethod()]
        public void ObliczBMRTest()
        {
            Bmr testowy = new Bmr(70, 176,25,1);
            double testbmr = testowy.ObliczBMR();
            int prosto = (int)testbmr;
            Assert.AreEqual(prosto, 1681);
        }


    }
}