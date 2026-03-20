using APr4v4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Formula1_Valid()
        {
            Assert.AreEqual(Formulas.calc_1(0, 0, 0), 0.0);
            Assert.AreEqual(Formulas.calc_1(5, 5, 0), 0.0);
            Assert.AreEqual(Formulas.calc_1(5, 0, 0), 0.71634, 0.001);
        }
    }
}
