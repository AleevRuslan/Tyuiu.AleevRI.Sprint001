using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint1.Task2.V2.Lib;

namespace Tyuiu.AleevRI.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 90;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(1.57, res);

        }

    }
}
