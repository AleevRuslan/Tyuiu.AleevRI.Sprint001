using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint1.Task1.V29.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0;
            double b = 3.0;
            double c = 1.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(1, res);

        }
    }
}
