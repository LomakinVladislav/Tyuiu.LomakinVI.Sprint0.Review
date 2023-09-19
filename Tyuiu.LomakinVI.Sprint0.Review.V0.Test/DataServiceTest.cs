using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint0.Review.V0.Lib;

namespace Tyuiu.LomakinVI.Sprint0.Review.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 2;
            int y = 3;
            int z = 4;
            int result = (int)DataService.Calc(x, y, z);

            Assert.AreEqual(45, result);
        }
    }
}
