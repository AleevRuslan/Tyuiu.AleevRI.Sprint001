using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint1.Task7.V9.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 5.983;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
