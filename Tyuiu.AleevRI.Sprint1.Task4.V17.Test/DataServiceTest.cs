using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AleevRI.Sprint1.Task4.V17.Lib;
namespace Tyuiu.AleevRI.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 36;
            double y = 3;
            double wait = 0.218;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
